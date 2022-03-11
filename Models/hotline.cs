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
        public string hotline1 { get; set; }

        [StringLength(200)]
        public string office { get; set; }

        [StringLength(50)]
        public string contactname { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(200)]
        public string note { get; set; }
    }
}
