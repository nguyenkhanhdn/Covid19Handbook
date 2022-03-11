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
        public string docNo { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public string content { get; set; }

        [StringLength(100)]
        public string link { get; set; }

        [StringLength(3)]
        public string status { get; set; }

        [StringLength(200)]
        public string note { get; set; }

        public short? views { get; set; }

        [StringLength(100)]
        public string officer { get; set; }
    }
}
