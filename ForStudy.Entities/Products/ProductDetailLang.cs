using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForStudy.Entities.Products
{
   public class ProductDetailLang
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        



        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Lang")]
        public int LangId { get; set; }
        public virtual Lang Lang { get; set; }
    }
}
