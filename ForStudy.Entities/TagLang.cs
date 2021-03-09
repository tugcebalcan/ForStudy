using ForStudy.Entities.Blogs;
using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
    public class TagLang
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TagId { get; set; }
        public int LangId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Lang Lang { get; set; }
        public virtual ICollection<BlogTag> BlogTags { get; set; } = new HashSet<BlogTag>();
        public virtual ICollection<ProductTag> ProductTags { get; set; } = new HashSet<ProductTag>();
    }
}
