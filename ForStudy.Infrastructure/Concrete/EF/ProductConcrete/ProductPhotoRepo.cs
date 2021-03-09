using ForStudy.Data.Abstract.ProductAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Data.Concrete.EfCore.ProductConcrete
{
    public class ProductPhotoRepo : EfCoreGenericRepo<ProductPhoto, ApplicationDbContext>, IProductPhotoRepo
    {
    }
}
