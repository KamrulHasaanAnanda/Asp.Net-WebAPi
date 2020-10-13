using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Inventory
    {
        [Key]
        public int iid { get; set; }

        public string iname { get; set; }

        public string iamount { get; set; }

        public string istatus { get; set; }
    }
}