using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
    public class Tag : BaseEntity
    {
        public virtual ICollection<TagLang> TagLangs { get; set; } = new HashSet<TagLang>();


    }
}
