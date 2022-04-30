namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hotline
    {
        public int Id { get; set; }

        [Column("hotline")]
        [StringLength(20)]
        [Display(Name = "Đường dây nóng")]
        public string hotline1 { get; set; }

        [StringLength(200)]
        [Display(Name = "Cơ quan")]
        public string office { get; set; }

        [StringLength(50)]
        [Display(Name = "Người đại diện")]
        public string contactname { get; set; }

        [StringLength(100)]
        [Display(Name = "Địa chỉ")]
        public string address { get; set; }

        [StringLength(200)]
        [Display(Name = "Ghi chú")]
        public string note { get; set; }
    }
}
