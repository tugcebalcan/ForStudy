using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.BlogAbstract
{
    public interface IBlogRepo:IGenericRepo<Blog>
    {
        List<Blog> GetAll();
        List<Blog> GetById(int id);
        List<Blog> BlogDescending(int count);

        Task UpdateBlogCategoryLangs(Blog model, int[] categoryIds);
        Task UpdateBlogTagLangs(Blog model, int[] tagIds);
    }
}
