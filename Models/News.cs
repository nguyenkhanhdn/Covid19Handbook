namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống.")]
        [StringLength(200)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tóm tắt không được trống.")]
        [Display(Name = "Tóm tắt")]
        public string Brief { get; set; }

        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày tạo")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Nội dung không được trống.")]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [StringLength(50)]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }
        [StringLength(3)]
        [Display(Name = "Trạng thái")]
        public string Status { get; set; }
        [Display(Name = "Số lượt xem")]
        public short? View { get; set; }
        [Display(Name = "Loại tin tức")]
        public int CatId { get; set; }
        [Display(Name = "Loại tin tức")]
        public virtual Category Category { get; set; }
    }
}
