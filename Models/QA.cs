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
        public string question { get; set; }

        public string Answer { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }
    }
}
