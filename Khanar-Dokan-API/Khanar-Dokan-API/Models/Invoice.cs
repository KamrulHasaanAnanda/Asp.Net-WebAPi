using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceNumber { get; set; }

        public int uid { get; set; }

        public System.DateTime OrderDate { get; set; }

        public decimal Subtotal { get; set; }

        public string ShipMethod { get; set; }

        public decimal Shipping { get; set; }

        public decimal SalesTax { get; set; }

        public decimal Total { get; set; }

        [Required]
        public string CreditCardType { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Required]
        public int ExpirationMonth { get; set; }

        [Required]
        public int ExpirationYear { get; set; }


        public virtual User Users { get; set; }

        //public IEnumerable<Invoice> Invoices { get; set; }
    }
}