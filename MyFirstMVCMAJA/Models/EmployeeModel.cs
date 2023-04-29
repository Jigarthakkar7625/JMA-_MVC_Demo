using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstMVCMAJA.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Please enter employee Name !!")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Please enter min 4 and max 10 characters !!")]
        public string EmployeeName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email address!")]
        [EmailAddress(ErrorMessage = "Please enter valid email address!")]
        public string Email { get; set; }


        [DisplayName("User Name")]
        [Required(ErrorMessage = "Please enter User Name!")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter proper Username!")]
        public string UserName { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Please enter Age !!")]
        [Range(18, 35, ErrorMessage = "Please enter value betweeb 18 to 36 !!")]
        public int Age { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter Password !!")]
        public int Password { get; set; }

        [DisplayName("ConfirmPassword")]
        [Required(ErrorMessage = "Please enter ConfirmPassword !!")]
        [Compare("Password", ErrorMessage = "Password and Confirm password is not matched!!")]
        public int ConfirmPassword { get; set; }
    }
}