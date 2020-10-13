using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class History
    {
        [Key]
        public int hid { get; set; }

        public int uid { get; set; }

        public int fid { get; set; }

        public string saddress { get; set; }

        public string sphone { get; set; }

        public System.DateTime hdate { get; set; }

        public string hstatus { get; set; }

        public int hqty { get; set; }


        public virtual FoodItem FoodItems { get; set; }

        public virtual User Users { get; set; }
    }
}