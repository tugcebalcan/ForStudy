using ForStudy.Data.Abstract.BlogAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.BlogConcrete
{
    public class BlogRepo : EfCoreGenericRepo<Blog, ApplicationDbContext> , IBlogRepo
    {
        public List<Blog> BlogDescending(int count)
        {
            using (var context = new ApplicationDbContext())
            {
                var model = context.Blogs
                    .Include(x => x.BlogLangs)
                        .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogPhotos)
                    .Include(x => x.BlogCategories)
                         .ThenInclude(x => x.CategoryLang)
                            .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogTags)
                        .ThenInclude(x => x.TagLang)
                            .ThenInclude(x => x.Lang)
                    .OrderByDescending(x => x.RecordedAtDate).Take(count).ToList();

                return model;
            }
        }


        public async Task UpdateBlogCategoryLangs(Blog model, int[] categoryIds)
        {
            using (var context = new ApplicationDbContext())
            {
                if (model != null)
                {
                    var blog = await context.Blogs
                                                  .Include(x => x.BlogCategories)
                                                  .FirstOrDefaultAsync(x => x.Id == model.Id);

                    
                    blog.BlogCategories = categoryIds.Select(catid => new BlogCategory()
                    {
                        BlogId = blog.Id,
                        CategoryLangId = catid
                    }).ToList();


                    await context.SaveChangesAsync();
                }
            }
        }
        public async Task UpdateBlogTagLangs(Blog model, int[] tagIds)
        {
            using (var context = new ApplicationDbContext())
            {
                var blog = await context.Blogs
                                              .Include(x => x.BlogTags)
                                              .FirstOrDefaultAsync(x => x.Id == model.Id);
               
                blog.BlogTags = tagIds.Select(tagid => new BlogTag()
                {
                    BlogId = blog.Id,
                    TagLangId = tagid
                }).ToList();

                await context.SaveChangesAsync();
            }
        }

        public List<Blog> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Blogs
                     .Include(x => x.BlogLangs)
                        .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogPhotos)
                    .Include(x => x.BlogCategories)
                         .ThenInclude(x => x.CategoryLang)
                            .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogTags)
                        .ThenInclude(x => x.TagLang)
                            .ThenInclude(x => x.Lang).ToList();
            }
        }

        public async Task<Blog> GetById(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.Blogs
                     .Include(x => x.BlogLangs)
                        .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogPhotos)
                    .Include(x => x.BlogCategories)
                         .ThenInclude(x => x.CategoryLang)
                            .ThenInclude(x => x.Lang)
                    .Include(x => x.BlogTags)
                        .ThenInclude(x => x.TagLang)
                            .ThenInclude(x => x.Lang).FirstOrDefaultAsync(x => x.Id == id);
            }
        }

    }
}
