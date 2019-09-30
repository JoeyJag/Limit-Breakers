using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Limit_Breakers.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }

        public ICollection<Games> Products { get; set; }
    }
}