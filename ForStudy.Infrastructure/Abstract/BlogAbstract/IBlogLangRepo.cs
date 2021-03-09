using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.BlogAbstract
{
    public interface IBlogLangRepo : IGenericRepo<BlogLang>
    {
        List<BlogLang> OrderByDescending(string lang);
        Task<BlogLang> GetBlogLangByBlog(string code, int id);
        Task<BlogLang> GetBlogItem(string slugurl, int urlid, string _lang);
        Task<List<BlogLang>> GetOtherBlogLangs(string _lang, int id);

    }
}
