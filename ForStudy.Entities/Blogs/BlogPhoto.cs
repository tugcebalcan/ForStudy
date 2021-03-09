using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Blogs
{
   public class BlogPhoto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCover { get; set; }
        public bool IsMain { get; set; }
        
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
