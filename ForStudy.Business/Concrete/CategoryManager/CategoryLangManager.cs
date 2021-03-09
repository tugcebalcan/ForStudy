using ForStudy.Business.Abstract.CategoryService;
using ForStudy.Data.Abstract.CategoryAbstract;
using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Concrete.CategoryManager
{
    public class CategoryLangManager : ICategoryLangService
    {
        private readonly ICategoryLangRepo _categoryLangRepo;

        public CategoryLangManager(ICategoryLangRepo categoryLangRepo)
        {
            this._categoryLangRepo = categoryLangRepo;
        }

        public async Task Create(CategoryLang categoryLang)
        {
            await _categoryLangRepo.Create(categoryLang);
        }

        public List<CategoryLang> GetAll()
        {
            return _categoryLangRepo.GetAll();
        }

        public List<CategoryLang> GetAllIsActive()
        {
            return _categoryLangRepo.GetAllIsActive();
        }

        public async Task<List<CategoryLang>> GetByCategory(int id)
        {
            return await _categoryLangRepo.GetByCategory(id);
        }

        public async Task<CategoryLang> GetById(int id)
        {
            return await _categoryLangRepo.GetById(id);
        }

        public async Task Update(CategoryLang categoryLang)
        {
            await _categoryLangRepo.Update(categoryLang);
        }
    }
}
