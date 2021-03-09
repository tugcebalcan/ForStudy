using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.BlogAbstract
{
    public interface IBlogPhotoRepo : IGenericRepo<BlogPhoto>
    {
        List<BlogPhoto> GetAllBlogPhoto();
        Task RemoveBlogPhotoInBlog(Blog blog);
        Task RemoveBlogPhotoIsNotMain(Blog blog);
    }
}
