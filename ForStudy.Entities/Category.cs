using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
    public class Category : BaseEntity
    {
        public virtual ICollection<CategoryLang> CategoryLangs { get; set; } = new HashSet<CategoryLang>();
    }
}
