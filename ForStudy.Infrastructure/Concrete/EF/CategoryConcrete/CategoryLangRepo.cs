using ForStudy.Data.Abstract.CategoryAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.CategoryConcrete
{
    public class CategoryLangRepo : EfCoreGenericRepo<CategoryLang, ApplicationDbContext>, ICategoryLangRepo
    {
       
        public List<CategoryLang> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.CategoryLangs.ToList();
            }
        }

        public List<CategoryLang> GetAllIsActive()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.CategoryLangs.Include(x => x.BlogCategories).ThenInclude(x => x.Blog)
                                            .Include(x => x.ProductCategories).ThenInclude(x => x.Product)
                                            .Include(x=>x.Lang)
                                            .Include(x => x.Category)
                                            .Where(x => x.Category.IsActive == true && x.Lang.Code.ToLower() == "tr")
                                            .OrderByDescending(x => x.Category.RecordedAtDate).ToList();
            }
        }

        public async Task<List<CategoryLang>> GetByCategory(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.CategoryLangs.Include(x => x.BlogCategories).ThenInclude(x => x.Blog)
                                            .Include(x => x.ProductCategories).ThenInclude(x => x.Product)
                                            .Include(x => x.Lang)
                                            .Include(x => x.Category)
                                            .Where(x => x.Category.IsActive == true && x.CategoryId == id)
                                            .ToListAsync();
            }
        }

        public async Task<CategoryLang> GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.CategoryLangs.FirstOrDefaultAsync(x => x.Category.IsActive == true && x.Id == id);
            }
        }

        
    }
}