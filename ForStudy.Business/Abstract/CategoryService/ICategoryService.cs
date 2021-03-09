using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Abstract.CategoryService
{
   public interface ICategoryService
    {
        Task Create(Category category);
        Task Update(Category category);
        List<Category> GetAll();
        Category GetById(int id);
        List<Category> GetCategoriesOrderDescending(int count);
    }
}
