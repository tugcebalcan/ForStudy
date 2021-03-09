using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Products
{
   public class ProductPhoto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCover { get; set; }
        public bool IsMain { get; set; }
        
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
