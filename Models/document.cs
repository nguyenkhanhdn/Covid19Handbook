namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class document
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Display(Name = "Số VB")]
        public string docNo { get; set; }

        [StringLength(200)]
        [Display(Name = "Tiêu đề")]
        public string title { get; set; }
        
        [Display(Name = "Ngày ban hành")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd / MM / yyyy}")]
        public DateTime? date { get; set; }
        [Display(Name = "Nội dung")]
        public string content { get; set; }

        [StringLength(200)]
        [Display(Name = "Link văn bản")]
        public string link { get; set; }

        [StringLength(3)]
        [Display(Name = "Trạng thái")]
        public string status { get; set; }

        [StringLength(200)]
        [Display(Name = "Ghi chú")]
        public string note { get; set; }
        [Display(Name = "Số lượt xem")]
        public short? views { get; set; }

        [StringLength(100)]
        [Display(Name = "Đơn vị ban hành")]
        public string officer { get; set; }
    }
}
