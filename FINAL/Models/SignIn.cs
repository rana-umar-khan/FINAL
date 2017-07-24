using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FINAL.Models
{
    public class SignIn
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Username")]
        [StringLength(4, ErrorMessage = "Invalid Email")]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [RegularExpression(@"^.{4,40}$",
         ErrorMessage = "Invalid Password")]
        public string password { get; set; }
    }
}