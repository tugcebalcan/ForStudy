using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Blogs
{
    public class BlogTag
    {
        public int BlogId { get; set; }
        public int TagLangId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual TagLang TagLang { get; set; }
    }
}
