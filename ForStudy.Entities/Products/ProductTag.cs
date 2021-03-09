using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Products
{
    public class ProductTag
    {
        public int ProductId { get; set; }
        public int TagLangId { get; set; }

        public virtual Product Product { get; set; }
        public virtual TagLang TagLang { get; set; }
    }
}
