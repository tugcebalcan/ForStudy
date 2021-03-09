using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
   public class Seo : BaseEntity
    {
        public int UniqueId { get; set; }
        public string Page { get; set; }
        public virtual ICollection<SeoLang> SeoLangs { get; set; } = new HashSet<SeoLang>();
    }
}
