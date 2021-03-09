using ForStudy.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.CategoryAbstract
{
   public interface ICategoryRepo : IGenericRepo<Category>
    {
        List<Category> GetAll( );
        Category GetById(int id);
        List<Category> GetCategoriesOrderDescending(int count);
    }
}
