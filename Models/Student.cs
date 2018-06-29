using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
using System;

namespace demo_school_app.Models
{

    [Bind(Exclude = "ID")]
    public class Student
    {
        [ScaffoldColumn(false)]
        public int ID{ get; set;}


        [Required, MaxLength(30)]
        [DisplayName("First Name")]
        public string FirstName{ get; set;}


        [Required, MaxLength(30)]
        [DisplayName("Last Name")]
        public string LastName{ get; set;}



        [Required(ErrorMessage = "Please enter time"), MaxLength(20)]
        [DisplayName("Current date with time")]
        public String createdAt { get; set; }


        [MaxLength(20)]
        [DisplayName("Middle Name")]
        public string MiddleName{ get; set;}
        
    }

}