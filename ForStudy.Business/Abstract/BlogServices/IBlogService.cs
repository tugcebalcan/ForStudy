using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Abstract.BlogServices
{
   public interface IBlogService
    {
        List<Blog> GetAll();
        Task<Blog> GetById(int id);
        List<Blog> BlogDescending(int count);

        Task Remove(Blog blog);
        Task Update(Blog entity);
        Task Create(Blog blog);
        Task UpdateBlogTagLangs(Blog model, int[] tagIds);
        Task UpdateBlogCategoryLangs(Blog model, int[] categoryIds);
    }
}
