using ForStudy.Data.Abstract.ProductAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForStudy.Data.Concrete.EfCore.ProductConcrete
{
    public class ProductDetailLangRepo : EfCoreGenericRepo<ProductDetailLang, ApplicationDbContext>, IProductDetailLangRepo
    {
        public List<ProductDetailLang> OrderByDescending(string lang)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.ProductDetailLangs
                                        .Include(x => x.Product)
                                            .ThenInclude(x => x.ProductCategories)
                                                .ThenInclude(x => x.CategoryLang)
                                        .Include(x => x.Product)
                                            .ThenInclude(x => x.ProductPhotos)
                                        .Include(x => x.Product)
                                            .ThenInclude(x => x.ProductDetailLangs)
                                        .Include(x => x.Product)
                                            .ThenInclude(x => x.ProductTags)
                                                .ThenInclude(x => x.TagLang)
                                        .Include(x => x.Lang)
                                        .OrderByDescending(x => x.Product.RecordedAtDate).Where(x => x.Product.IsActive == true && x.Lang.Code.ToLower() == lang).Take(16).ToList();
            }
        }
    }
}
