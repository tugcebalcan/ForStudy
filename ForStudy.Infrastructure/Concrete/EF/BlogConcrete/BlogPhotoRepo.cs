using ForStudy.Data.Concrete.EfCore;
using ForStudy.Data.Abstract.BlogAbstract;
using ForStudy.Data.ApplicationDb;
using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForStudy.Data.Concrete.EF;

namespace ForStudy.Data.Concrete.EfCore.BlogConcrete
{
    public class BlogPhotoRepo : EfCoreGenericRepo<BlogPhoto, ApplicationDbContext>, IBlogPhotoRepo
    {
        public List<BlogPhoto> GetAllBlogPhoto()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.BlogPhotos.ToList();
            }
        }

        public async Task RemoveBlogPhotoInBlog(Blog blog)
        {
            using (var context = new ApplicationDbContext())
            {
                context.BlogPhotos.Remove(blog.BlogPhotos.FirstOrDefault(x => x.IsMain == true));
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveBlogPhotoIsNotMain(Blog blog)
        {
            using(var context = new ApplicationDbContext())
            {
                context.BlogPhotos.RemoveRange(blog.BlogPhotos.Where(x => x.IsMain == false));
                await context.SaveChangesAsync();
            }
        }
    }
}