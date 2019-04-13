using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DateTimePicker.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Full Name:")]
        public string FullName { get; set; }
        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Display(Name = "Date of Birth:")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Time:")]
        public string StartTime { get; set; }
        [Display(Name = "Is Enrolled:")]
        public bool IsEnrolled { get; set; }

    }
}