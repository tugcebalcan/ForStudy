using System;
using System.Collections.Generic;
using System.Text;

namespace ForStudy.Entities
{
   public class SeoLang
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keys { get; set; }
        public string Desc { get; set; }

        public int SeoId { get; set; }
        public int LangId { get; set; }
        public virtual Seo Seo { get; set; }
        public virtual Lang Lang { get; set; }
    }
}
