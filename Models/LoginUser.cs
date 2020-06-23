using System.ComponentModel.DataAnnotations;

namespace exam.Models
{
    public class LoginUser{
        [Required (ErrorMessage = "Email is required")]
        [EmailAddress (ErrorMessage = "Please enter a valid email address")]
        public string LoginEmail {get;set;}

        [Required (ErrorMessage = "Password is required")]
        [DataType ("Password")]
        public string LoginPassword {get;set;}

    }
}