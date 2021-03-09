using ForStudy.Entities.Blogs;
using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
   public class CategoryLang
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int LangId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Lang Lang { get; set; }
        public virtual ICollection<BlogCategory> BlogCategories { get; set; } = new HashSet<BlogCategory>();

        public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
    }
}
