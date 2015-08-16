using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.WebUI.Frontend.Models
{
    public class RegisterUserModel
    {
        [DataType(DataType.Text)]
        [StringLength(32, MinimumLength = 3)]
        [Required()]
        public string Fist_name { get; set; }

        [DataType(DataType.Text)]
        [StringLength(32, MinimumLength = 3)]
        [Required()]
        public string Surname { get; set; }

        [DataType(DataType.Text)]
        [StringLength(32, MinimumLength = 3)]
        [Required()]
        public string Logins { get; set; }

        [DataType(DataType.Password)]
        [StringLength(32, MinimumLength = 6)]
        [Required()]
        public string Passwords { get; set; }

        [Compare("Passwords")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}