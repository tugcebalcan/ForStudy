using ForStudy.Data.Abstract.CategoryAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.CategoryConcrete
{
    public class CategoryRepo : EfCoreGenericRepo<Category, ApplicationDbContext>, ICategoryRepo
    {
        public List<Category> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Categories
                    .Include(x => x.CategoryLangs).ThenInclude(x=> x.Lang)
                    .ToList();
            }
        }

        public Category GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Categories
                    .Include(x => x.CategoryLangs).ThenInclude(x => x.Lang)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Category> GetCategoriesOrderDescending(int count)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Categories
                    .Include(x => x.CategoryLangs).ThenInclude(x => x.Lang)
                    .OrderByDescending(x => x.RecordedAtDate).Take(count).ToList();
            }
        }

    }
}
