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
    public class BlogPhotoManager : IBlogPhotoService
    {
        private readonly IBlogPhotoRepo _blogPhotoRepo;

        public BlogPhotoManager(IBlogPhotoRepo blogPhotoRepo)
        {
            this._blogPhotoRepo = blogPhotoRepo;
        }
        public async Task Create(BlogPhoto entity)
        {
            await _blogPhotoRepo.Create(entity);
        }

        public async Task Remove(BlogPhoto entity)
        {
            await _blogPhotoRepo.Remove(entity);
        }

        public async Task Update(BlogPhoto entity)
        {
            await _blogPhotoRepo.Update(entity);
        }
    }
}
