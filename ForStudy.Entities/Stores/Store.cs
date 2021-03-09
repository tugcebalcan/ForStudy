using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities.Stores
{
    public class Store : BaseEntity
    {
        public string InfluencerId  { get; set; }
        public virtual ICollection<StoreProduct> StoreProducts { get; set; }  =  new HashSet<StoreProduct>();
    }
}
