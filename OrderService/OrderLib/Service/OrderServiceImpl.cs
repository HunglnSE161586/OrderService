using OrderLib.BusinessObj;
using OrderLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib.Service
{
    public class OrderServiceImpl : IOrderService
    {
        private OrderRepository _orderRepository;        

        public OrderServiceImpl()
        {
            _orderRepository = new OrderRepository();
        }

        public List<Orders> GetOrders()
        {
            List<Orders> orders = _orderRepository.GetOrders();
            return orders;
        }
    }
}
