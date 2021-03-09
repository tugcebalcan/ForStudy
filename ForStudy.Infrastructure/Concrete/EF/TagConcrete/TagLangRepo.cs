using ForStudy.Data.Abstract.TagAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.TagConcrete
{
    public class TagLangRepo : EfCoreGenericRepo<TagLang, ApplicationDbContext>, ITagLangRepo
    {

        public List<TagLang> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.TagLangs.ToList();
            }
        }

        public List<TagLang> GetAllIsActive()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.TagLangs.Include(x => x.BlogTags).ThenInclude(x => x.Blog)
                                            .Include(x => x.ProductTags).ThenInclude(x => x.Product)
                                            .Include(x => x.Lang)
                                            .Include(x=>x.Tag)
                                            .Where(x => x.Tag.IsActive == true && x.Lang.Code.ToLower() == "tr")
                                            .OrderByDescending(x => x.Tag.RecordedAtDate).ToList();
            }
        }

        public async Task<TagLang> GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.TagLangs.FirstOrDefaultAsync(x => x.Tag.IsActive == true && x.Id == id);
            }
        }

        public async Task<List<TagLang>> GetByTag(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.TagLangs.Include(x => x.BlogTags).ThenInclude(x => x.Blog)
                                            .Include(x => x.ProductTags).ThenInclude(x => x.Product)
                                            .Include(x => x.Lang)
                                            .Include(x => x.Tag)
                                            .Where(x => x.Tag.IsActive == true && x.TagId == id)
                                            .ToListAsync();
            }
        }
    }
}
