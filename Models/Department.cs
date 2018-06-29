using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using System;

namespace demo_school_app.Models
{
    [Bind(Exclude = "DepartmentID")]
    public class Department
    { 

        [ScaffoldColumn(false)]
        public int DepartmentID{ get; set; }

        [Required, MaxLength(40)]
        [DisplayName("Name")]
        public String Name{ get; set; }


        [Required(ErrorMessage = "Please enter time"), MaxLength(20)]
        [DisplayName("Current date with time")]
        public String createdAt { get; set; }



        public ICollection<Course> courses { get; set; }


        public ICollection<Student> students { get; set;}

    }

}