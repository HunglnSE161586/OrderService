using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderLib.BusinessObj;
using OrderLib.Service;

namespace OrderService.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService OrderService;

        public OrderController()
        {
            OrderService = new OrderServiceImpl();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Orders>> GetOrders()
        {
            return Ok(OrderService.GetOrders());
        }
    }
}
