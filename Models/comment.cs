namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comment
    {
        public int Id { get; set; }

        [Column("comment")]
        public string comment1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(50)]
        public string author { get; set; }

        [StringLength(200)]
        public string note { get; set; }

        public short? likes { get; set; }

        public int? QAId { get; set; }
    }
}
