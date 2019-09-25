using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Limit_Breakers.Models
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [DisplayName("Email Address:")]
        [Required(ErrorMessage = "Please enter your Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MinLength(4)]
        [DisplayName("Username:")]
        [Required(ErrorMessage = "Please enter your desired Username")]
        public string Username { get; set; }
        [MinLength(5)]
        [DisplayName("Password:")]
        [Required(ErrorMessage = "Please enter a Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MinLength(5)]
        [DisplayName("Confirm Password:")]
        [Required(ErrorMessage = "Please Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [DisplayName("Tokens:")]
        [Required(ErrorMessage = "Please enter amount of Tokens")]
        public int Tokens { get; set; }
        [DisplayName("Phone Number:")]
        public string PhoneNumber { get; set; }
        [DisplayName("Type of User:")]
        [Required(ErrorMessage = "Please choose a Type of User")]
        public string UserType { get; set; }

    }
}