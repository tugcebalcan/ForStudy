using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Business.Abstract.BlogServices
{
   public interface IBlogPhotoService
    {
        Task Create(BlogPhoto entity);
        Task Update(BlogPhoto entity);
        Task Remove(BlogPhoto entity);

    }
}
