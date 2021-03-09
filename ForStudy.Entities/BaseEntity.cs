using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForStudy.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        public DateTime RecordedAtDate { get; set; } = DateTime.Now;
        public string SlugUrl { get; set; }
        public int UrlId { get; set; }
        public DateTime UpdatedAtDate { get; set; }

        public bool IsBlog { get; set; }
        public bool IsProduct { get; set; }
        public bool IsPage { get; set; }
    }
}
