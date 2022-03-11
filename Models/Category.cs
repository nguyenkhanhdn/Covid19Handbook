namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public Category()
        {
            News = new HashSet<News>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên loại không được để trống.")]
        [StringLength(200)]
        [Display(Name = "Loại tin tức")]
        public string name { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
