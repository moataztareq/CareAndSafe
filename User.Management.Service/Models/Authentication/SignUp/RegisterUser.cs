using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Service.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage = "First Name Is Required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "UserName is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Phone]
        public string? PhoneNamber { get; set; }
        public string? Address { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [PasswordPropertyText]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        public List<string>? Roles { get; set; }

    }
}
