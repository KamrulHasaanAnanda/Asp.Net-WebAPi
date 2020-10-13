using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Order
    {
        [Key]
        public int oid { get; set; }

        public string oStatus { get; set; }

        public virtual History Histories { get; set; }

        public virtual User Users { get; set; }
    }
}