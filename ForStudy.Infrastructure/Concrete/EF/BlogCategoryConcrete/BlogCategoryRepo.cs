using ForStudy.Data.Abstract.BlogCategoryAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Concrete.EfCore.BlogCategoryConcrete
{
    public class BlogCategoryRepo : IBlogCategoryRepo
    {
        public async Task<BlogCategory> GetBlogCategoryForBlogItemPage(string slugurl, int urlid, string _lang)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.BlogCategories.FirstOrDefaultAsync(x => x.CategoryLang.Category.IsActive == true
                                        && x.CategoryLang.Lang.Code.ToLower() == _lang && x.CategoryLang.Category.SlugUrl.ToLower() == slugurl && x.CategoryLang.Category.UrlId == urlid);
            }
        }
    }
}
