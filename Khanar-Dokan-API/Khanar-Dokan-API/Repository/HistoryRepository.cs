using Khanar_Dokan_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Repository
{
    public class HistoryRepository : Repository<History>, iHistoryRepository
    {
        public List<History> GetOrderFromCustomer()
        {
            return this.context.Histories.Where(x => x.hstatus == "Pending").ToList();
        }

        public List<History> GetCheifOrderPending()
        {
            return this.context.Histories.Where(x => x.hstatus == "Cheif").ToList();
        }

        public List<History> GetDeliveryBoyOrderPending()
        {
            return this.context.Histories.Where(x => x.hstatus == "DeliveryBoy").ToList();
        }

        public List<History> GetOrderDone()
        {
            return this.context.Histories.Where(x => x.hstatus == "Done").ToList();
        }
    }
}