using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Employee
    {
        [Key]
        public int eid { get; set; }

        public int uid { get; set; }

        [Required]
        public string etype { get; set; }

        [Required]
        public decimal esalary { get; set; }

        public virtual User Users { get; set; }
    }
}