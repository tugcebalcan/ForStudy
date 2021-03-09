using ForStudy.Data.Abstract.ProductAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Data.Concrete.EF;
using ForStudy.Entities.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.ProductConcrete
{
    public class ProductRepo : EfCoreGenericRepo<Product, ApplicationDbContext>, IProductRepo
    {
        public List<Product> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Products
                                     .Include(x => x.ProductPhotos)
                                     .Include(x => x.ProductDetailLangs)
                                         .ThenInclude(x => x.Lang)
                                     .Include(x => x.ProductCategories)
                                         .ThenInclude(x => x.CategoryLang)
                                            .ThenInclude(x => x.Lang)
                                     .Include(x => x.ProductTags)
                                        .ThenInclude(x => x.TagLang)
                                            .ThenInclude(x => x.Lang).ToList();
            }
        }
    
        public async Task<Product> GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Products
                     .Include(x => x.ProductDetailLangs)
                        .ThenInclude(x => x.Lang)
                    .Include(x => x.ProductPhotos)
                    .Include(x => x.ProductCategories)
                         .ThenInclude(x => x.CategoryLang)
                            .ThenInclude(x => x.Lang)
                    .Include(x => x.ProductTags)
                        .ThenInclude(x => x.TagLang)
                            .ThenInclude(x => x.Lang).FirstOrDefaultAsync(x => x.Id == id);
            }
        }

        public async Task UpdateProductCategoryLangs(Product model, int[] categoryIds)
        {
            using (var context = new ApplicationDbContext())
            {
                if (model != null)
                {
                    var product = await context.Products
                                                  .Include(x => x.ProductCategories)
                                                  .FirstOrDefaultAsync(x => x.Id == model.Id);


                    product.ProductCategories = categoryIds.Select(catid => new ProductCategory()
                    {
                        ProductId = product.Id,
                        CategoryLangId = catid
                    }).ToList();


                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task UpdateProductTagLangs(Product model, int[] tagIds)
        {
            using (var context = new ApplicationDbContext())
            {
                var product = await context.Products
                                              .Include(x => x.ProductTags)
                                              .FirstOrDefaultAsync(x => x.Id == model.Id);

                product.ProductTags = tagIds.Select(tagid => new ProductTag()
                {
                    ProductId = product.Id,
                    TagLangId = tagid
                }).ToList();

                await context.SaveChangesAsync();
            }
        }
    }
}
