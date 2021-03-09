using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Products
{
   public class ProductCategory
    {
        public int ProductId { get; set; }
        public int CategoryLangId { get; set; }

        public virtual Product Product { get; set; }
        public virtual CategoryLang CategoryLang { get; set; }
    }
}
