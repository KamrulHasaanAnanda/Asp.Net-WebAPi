using Khanar_Dokan_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Repository
{
    public class InvoiceRepository : Repository<Invoice>, iInvoiceRepository
    {
        public List<Invoice> GetInvoicesWithUser(int id)
        {
            return this.context.Invoices.Include("User").Where(x => x.uid == id).ToList();
        }
    }
}