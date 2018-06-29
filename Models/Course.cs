using System.Collections.Generic;
using demo_school_app.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.Web.Mvc;
using System.ComponentModel;

namespace demo_school_app.Models
{
    [Bind(Exclude = "CourseID")]
    public class Course
    {
        [ScaffoldColumn(false)]
        public int CourseID { get; set; }


        [Required(ErrorMessage = "Name is required"), MaxLength(50)]
        public String Name {get ; set; }

        [Required(ErrorMessage = "Please enter time"), MaxLength(20)]
        [DisplayName("Current date with time")]
        public String createdAt { get; set; }


        public ICollection<Student> students { get; set; }
    }

}