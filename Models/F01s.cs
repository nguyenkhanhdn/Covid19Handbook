namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F01s
    {
        public int Id { get; set; }

        public string content { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(3)]
        public string status { get; set; }

        public short? views { get; set; }
    }
}
