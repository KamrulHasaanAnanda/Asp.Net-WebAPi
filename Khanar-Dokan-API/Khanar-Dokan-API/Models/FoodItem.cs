using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class FoodItem
    {
        [Key]
        public int fid { get; set; }

        [Required]
        public string fname { get; set; }

        [Required]
        public int fprice { get; set; }

        [Required]
        public string fdetails { get; set; }

        public string fStatus { get; set; }

        public string fimagefile { get; set; }

        public int catid { get; set; }

        public virtual Category Categories { get; set; }

    }
}