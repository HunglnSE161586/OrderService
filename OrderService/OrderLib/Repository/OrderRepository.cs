using OrderLib.BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib.Repository
{
    public class OrderRepository
    {
        private OrderServiceContext _context;
        public OrderRepository()
        {
            _context = new OrderServiceContext();
        }
        public List<Orders> GetOrders()
        {
            List<Orders> orders= _context.Orders.ToList();
            return orders;
        }
    }
}
