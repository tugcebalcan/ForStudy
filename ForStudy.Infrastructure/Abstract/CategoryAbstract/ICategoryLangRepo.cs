using ForStudy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.CategoryAbstract
{
    public interface ICategoryLangRepo : IGenericRepo<CategoryLang>
    {
        List<CategoryLang> GetAllIsActive();

        Task<CategoryLang> GetById(int id);

        Task<List<CategoryLang>> GetByCategory(int id);

        List<CategoryLang> GetAll();

    }
}