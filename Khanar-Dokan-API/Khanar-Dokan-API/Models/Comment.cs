using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Comment
    {
        [Key]
        public int cid { get; set; }

        public int uid { get; set; }

        public int fid { get; set; }

        [Required]
        public string comment1 { get; set; }

        public virtual FoodItem FoodItems { get; set; }
        public virtual User Users { get; set; }
    }
}