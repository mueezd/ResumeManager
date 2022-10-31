using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [Range(25,55, ErrorMessage = "Currently, We Have no position Vacent for Age")]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        [Required]
        [StringLength(50)]
        public string Qulification { get; set; }

        [Required]
        [Range(1,25, ErrorMessage = "Currently, We Have no position vacant for your exprience")]
        [DisplayName("Total Exprience in years")]
        public int TotalExprience { get; set; }
        public virtual List<Exprience> Expriences { get; set; } = new List<Exprience>();

        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Please choose the profile Photo")]
        [Display(Name = "Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
    }
}
