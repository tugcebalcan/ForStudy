using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Blogs
{
   public class BlogCategory
    {
        public int BlogId { get; set; }
        public int CategoryLangId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual CategoryLang CategoryLang { get; set; }
    }
}
