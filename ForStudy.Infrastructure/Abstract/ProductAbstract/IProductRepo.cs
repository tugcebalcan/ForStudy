using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.ProductAbstract
{
    public interface IProductRepo : IGenericRepo<Product>
    {
        List<Product> GetAll();
        Task UpdateProductCategoryLangs(Product model, int[] categoryIds);
        Task UpdateProductTagLangs(Product model, int[] tagIds);
        Task<Product> GetById(int id);
    }
}
