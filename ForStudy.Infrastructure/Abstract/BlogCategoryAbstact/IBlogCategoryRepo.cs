﻿using ForStudy.Entities;
using ForStudy.Entities.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForStudy.Data.Abstract.BlogCategoryAbstract
{
   public interface IBlogCategoryRepo
    {
        Task<BlogCategory> GetBlogCategoryForBlogItemPage(string slugurl, int urlid, string _lang);
    }
}
