using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Contact
    {
        [Key]
        public int Conid { get; set; }

        [Required]
        public string Conname { get; set; }

        [Required]
        public string Conemail { get; set; }

        public string Consubject { get; set; }

        [Required]
        public string Conmessage { get; set; }

        public string Constatus { get; set; }
    }
}