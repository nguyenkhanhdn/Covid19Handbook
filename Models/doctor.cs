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
        public string phone { get; set; }

        [StringLength(100)]
        public string doctorName { get; set; }

        [StringLength(150)]
        public string description { get; set; }

        [StringLength(200)]
        public string note { get; set; }
    }
}
