namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class doctor
    {
        public int Id { get; set; }

        [StringLength(20)]
        [Column(Order = 2)]
        [Display(Name ="Điện thoại")]
        public string phone { get; set; }

        [StringLength(100)]
        [Column(Order = 1)]
        [Display(Name = "Họ và tên")]
        public string doctorName { get; set; }

        [StringLength(150)]
        [Display(Name = "Mô tả")]
        public string description { get; set; }

        [StringLength(200)]
        [Display(Name = "Ghi chú")]
        public string note { get; set; }
    }
}
