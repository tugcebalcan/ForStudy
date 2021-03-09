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
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepo _blogRepo;

        public BlogManager(IBlogRepo blogRepo)
        {
            this._blogRepo = blogRepo;
        }

        public List<Blog> BlogDescending(int count)
        {
            return _blogRepo.BlogDescending(count);
        }

        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }

        public async Task<Blog> GetById(int id)
        {
            return await _blogRepo.GetById(id);
        }

        public async Task Remove(Blog blog)
        {
            if (blog != null)
            {
                await _blogRepo.Remove(blog);
            }
            else
                throw new ArgumentException("Parametre boş olamaz.", nameof(blog));
        }

        public async Task Create(Blog blog)
        {
            await _blogRepo.Create(blog);
        }

        public async Task Update(Blog entity)
        {
            await _blogRepo.Update(entity);
        }

        public async Task UpdateBlogCategoryLangs(Blog model, int[] categoryIds)
        {
            await _blogRepo.UpdateBlogCategoryLangs(model, categoryIds);
        }

        public async Task UpdateBlogTagLangs(Blog model, int[] tagIds)
        {
            await _blogRepo.UpdateBlogTagLangs(model, tagIds);
        }
    }
}
