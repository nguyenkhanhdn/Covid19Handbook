namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QA
    {
        public int Id { get; set; }

        [StringLength(250)]
        [Column(Order =1,TypeName ="Nvarchar")]
        [Display(Name = "Câu hỏi")]
        public string question { get; set; }
        [Display(Name = "Trả lời")]
        public string Answer { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string description { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày")]
        public DateTime? date { get; set; }
    }
}
