using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ResumeManager.Models
{
    public class Exprience
    {
        public Exprience()
        {

        }

        [Key]
        public int ExprienceId { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        public virtual Applicant Applicant { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public int YearsWorked { get; set; }
    }
}
