using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.ProductAbstract
{
    public interface IProductDetailLangRepo : IGenericRepo<ProductDetailLang>
    {
        List<ProductDetailLang> OrderByDescending(string lang);
    }
}
