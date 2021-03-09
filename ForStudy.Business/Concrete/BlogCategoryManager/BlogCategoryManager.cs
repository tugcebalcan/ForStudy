using ForStudy.Business.Abstract.BlogCategoryService;
using ForStudy.Data.Abstract.BlogCategoryAbstract;
using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Concrete.BlogCategoryManager
{
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IBlogCategoryRepo _blogCategoryRepo;

        public BlogCategoryManager(IBlogCategoryRepo blogCategoryRepo)
        {
            this._blogCategoryRepo = blogCategoryRepo;
        }
        public Task<BlogCategory> GetBlogCategoryForBlogItemPage(string slugurl, int urlid, string _lang)
        {
            return _blogCategoryRepo.GetBlogCategoryForBlogItemPage(slugurl, urlid, _lang);
        }
    }
}
