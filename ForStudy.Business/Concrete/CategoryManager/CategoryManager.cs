using ForStudy.Business.Abstract.CategoryService;
using ForStudy.Data.Abstract.CategoryAbstract;
using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Concrete.CategoryManager
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoryManager(ICategoryRepo categoryRepo)
        {
            this._categoryRepo = categoryRepo;
        }
        public async Task Create(Category category)
        {
            await _categoryRepo.Create(category);
        }

        public List<Category> GetAll()
        {
            return _categoryRepo.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepo.GetById(id);
        }

        public List<Category> GetCategoriesOrderDescending(int count)
        {
            return _categoryRepo.GetCategoriesOrderDescending(count);
        }

        public async Task Update(Category category)
        {
            await _categoryRepo.Update(category);
        }
    }
}
