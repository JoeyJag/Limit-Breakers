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
        public string Email { get; set; }
        [DisplayName("Username:")]
        public string Username { get; set; }
        [DisplayName("Password:")]
        public string Password { get; set; }
        [DisplayName("Tokens:")]
        public int Tokens { get; set; }
        [DisplayName("Phone Number:")]
        public string PhoneNumber { get; set; }
        [DisplayName("User Type:")]
        public string UserType { get; set; }

    }
}