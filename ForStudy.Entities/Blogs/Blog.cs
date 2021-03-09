using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Blogs
{
   public class Blog : BaseEntity
    {
        public int UniqueId { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<BlogLang> BlogLangs { get; set; } = new HashSet<BlogLang>();
        public virtual ICollection<BlogPhoto> BlogPhotos { get; set; } = new HashSet<BlogPhoto>();
        public virtual ICollection<BlogCategory> BlogCategories { get; set; } = new HashSet<BlogCategory>();
        public virtual ICollection<BlogTag> BlogTags { get; set; } = new HashSet<BlogTag>();

    }
}
