using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Products
{
    public class Product : BaseEntity
    {
        public int UniqueId { get; set; }

        public string SupplierId { get; set; }
        public float SupplierPrice { get; set; }
        public float AffileePrice { get; set; }
        public int Stoch { get; set; }
        public virtual ICollection<ProductDetailLang> ProductDetailLangs { get; set; } = new HashSet<ProductDetailLang>();
        public virtual ICollection<ProductPhoto> ProductPhotos { get; set; } = new HashSet<ProductPhoto>();
        public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new HashSet<ProductCategory>();
        public virtual ICollection<ProductTag> ProductTags { get; set; } = new HashSet<ProductTag>();

    }
}

