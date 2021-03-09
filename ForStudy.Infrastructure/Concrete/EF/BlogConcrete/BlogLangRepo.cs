using FinalProject.Data.Abstract.BlogAbstract;
using FinalProject.Data.ApplicationDb;
using FinalProject.Entities;
using FinalProject.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data.Concrete.EfCore.BlogConcrete
{
    public class BlogLangRepo : EfCoreGenericRepo<BlogLang, ApplicationDbContext>, IBlogLangRepo
    {
        public async Task<BlogLang> GetBlogItem(string slugurl, int urlid, string _lang)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.BlogLangs
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogCategories)
                                                .ThenInclude(x => x.CategoryLang)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogPhotos)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogLangs)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogTags)
                                                .ThenInclude(x => x.TagLang)
                                        .Include(x => x.Lang)
                                        .FirstOrDefaultAsync(x => x.Blog.IsActive == true
                                            && x.Lang.Code.ToLower() == _lang && x.Blog.SlugUrl.ToLower() == slugurl && x.Blog.UrlId == urlid);
            }
        }

        public async Task<BlogLang> GetBlogLangByBlog(string code, int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.BlogLangs.FirstOrDefaultAsync(x => x.Lang.Code.ToLower() == code && x.BlogId == id);
            }
        }

        public async Task<List<BlogLang>> GetOtherBlogLangs(string _lang, int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.BlogLangs
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogCategories)
                                                .ThenInclude(x => x.CategoryLang)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogPhotos)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogLangs)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogTags)
                                                .ThenInclude(x => x.TagLang)
                                        .Include(x => x.Lang)
                                        .Where(x => x.Blog.IsActive == true && x.Lang.Code.ToLower() == _lang && x.Blog.Id != id).Take(3).ToListAsync();
            }
        }

        public List<BlogLang> OrderByDescending(string lang)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.BlogLangs
                                        .Include(x=> x.Blog)
                                            .ThenInclude(x=> x.BlogCategories)
                                                .ThenInclude(x=> x.CategoryLang)
                                        .Include(x=> x.Blog)
                                            .ThenInclude(x=> x.BlogPhotos)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogLangs)
                                        .Include(x => x.Blog)
                                            .ThenInclude(x => x.BlogTags)
                                                .ThenInclude(x => x.TagLang)
                                        .Include(x=> x.Lang)
                                        .OrderByDescending(x => x.Blog.RecordedAtDate).Where(x => x.Blog.IsActive == true && x.Lang.Code.ToLower() == lang).Take(16).ToList();
            }
        }

       
    }
}