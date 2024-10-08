using OrderLib.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib.Service
{
    public interface IOrderService
    {
        List<Orders> GetOrders();
    }
}
