namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(4)]
        public string YearofBirth { get; set; }

        public double? Weight { get; set; }

        public double? Height { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        [StringLength(50)]
        public string Address { get; set; }
    }
}
