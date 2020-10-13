using Khanar_Dokan_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khanar_Dokan_API.Repository
{
    interface iHistoryRepository
    {
        List<History> GetOrderFromCustomer();

        List<History> GetCheifOrderPending();

        List<History> GetDeliveryBoyOrderPending();

        List<History> GetOrderDone();
    }
}
