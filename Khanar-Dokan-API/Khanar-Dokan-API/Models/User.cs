using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class User
    {
        [Key]
        public int uid { get; set; }

        [Required]
        public string uname { get; set; }

        [Required]
        public string uphone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string uemail { get; set; }

        [Required]
        public string uaddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string upassword { get; set; }

    }
}