using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covid19Handbook.Models
{
    public class Thankful
    {
        public int Id { get; set; }
        [Display(Name = "Nội dung")]
        public string Content { get; set; }

        public bool Status { get; set; }

    }
}