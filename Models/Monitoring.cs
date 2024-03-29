namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Monitoring")]
    public partial class Monitoring
    {
        public int Id { get; set; }
        [Display(Name = "Bệnh nhân")]
        public int PatientId { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày ban hành")]
        public DateTime reportDate { get; set; }

        public double bodytemp { get; set; }

        public double spo2 { get; set; }

        [Required]
        [StringLength(100)]
        public string symtomps { get; set; }

        [Required]
        [StringLength(200)]
        public string doctoradv { get; set; }

        public Patient Patient { get; set; }
    }
}
