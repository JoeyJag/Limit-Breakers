using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Limit_Breakers.Models
{
    public class Games
    {
        [Key]
        [Display(Name ="GameID")]
        public int GameID { get; set; }

        [Display(Name ="Category")]
        public int CategoryId { get; set; }

        [Display(Name ="Game Name")]
        public string GameName { get; set; }

        [Display(Name ="Price")]
        public int Price { get; set; }

        [Display(Name ="Time")]
        public DateTime Time { get; set; }
        
        [Display(Name ="Image")]
        public string Image { get; set; }

        public virtual Category Category { get; set; }
    }
}