using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Category
    {
        [Key]
        public int catid { get; set; }

        public string catname { get; set; }
    }
}