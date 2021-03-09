using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Abstract.CategoryService
{
   public interface ICategoryLangService
    {
        List<CategoryLang> GetAllIsActive();
        Task<CategoryLang> GetById(int id);
        List<CategoryLang> GetAll();
        Task Create(CategoryLang categoryLang);
        Task Update(CategoryLang categoryLang);
        Task<List<CategoryLang>> GetByCategory(int id);
    }
}

