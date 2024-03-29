namespace Covid19Handbook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên bệnh nhân")]
        public string Fullname { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name = "Năm sinh")]
        public string YearofBirth { get; set; }
        [Display(Name = "Cân nặng")]
        public double Weight { get; set; }
        [Display(Name = "Chiều cao")]
        public double Height { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }

        [StringLength(250)]
        [Display(Name = "Ghi chú")]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Phường")]
        public string Ward { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Quận")]
        public string District { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tỉnh")]
        public string Province { get; set; }

        public ICollection<Monitoring> Monitorings { get; set; }
    }
}
