using ForStudy.Business.Abstract.BlogServices;
using ForStudy.Data.Abstract.BlogAbstract;
using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Concrete.BlogManager
{
    public class BlogLangManager : IBlogLangService
    {
        private readonly IBlogLangRepo _blogLangRepo;

        public BlogLangManager(IBlogLangRepo blogLangRepo)
        {
            this._blogLangRepo = blogLangRepo;
        }

        public async Task Create(BlogLang entity)
        {
            await _blogLangRepo.Create(entity);
        }
        public async Task Update(BlogLang entity)
        {
            await _blogLangRepo.Update(entity);
        }

        public async Task Remove(BlogLang entity)
        {
            await _blogLangRepo.Remove(entity);
        }

        public async Task<BlogLang> GetBlogItem(string slugurl, int urlid, string _lang)
        {
            return await _blogLangRepo.GetBlogItem(slugurl, urlid, _lang);
        }

        public async Task<BlogLang> GetBlogLangByBlog(string code, int id)
        {
            return await _blogLangRepo.GetBlogLangByBlog(code, id);
        }

        public async Task<List<BlogLang>> GetOtherBlogLangs(string _lang, int id)
        {
            return await _blogLangRepo.GetOtherBlogLangs(_lang, id);
        }

        public List<BlogLang> OrderByDescending(string lang)
        {
            return _blogLangRepo.OrderByDescending(lang);
        }

      

      
    }
}
