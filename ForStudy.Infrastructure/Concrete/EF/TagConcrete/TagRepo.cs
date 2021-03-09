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
    public class TagRepo : EfCoreGenericRepo<Tag, ApplicationDbContext>, ITagRepo
    { 
        public List<Tag> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Tags
                    .Include(x => x.TagLangs).ThenInclude(x => x.Lang)
                    .ToList();
            }
        }

        public List<Tag> GetTagsOrderDescending(int count)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Tags
                    .Include(x => x.TagLangs).ThenInclude(x => x.Lang)
                    .OrderByDescending(x => x.RecordedAtDate).Take(count).ToList();
            }
        }

        public Tag GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Tags
                    .Include(x => x.TagLangs).ThenInclude(x => x.Lang)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

      
    }
}
