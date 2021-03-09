using ForStudy.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;



namespace ForStudy.Entities.Stores
{
    public class StoreProduct : BaseEntity
    {
        public virtual Product product { get; set; }
        public float Price { get; set; }
        public int Stoch { get; set; }



        public int StoreId { get; set; }
        public virtual Store Store { get; set; }

    }
}
