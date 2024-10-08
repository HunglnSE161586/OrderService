using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderLib.BusinessObj;
using OrderLib.Service;

namespace OrderServiceAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService orderService=new OrderServiceImpl();
        [HttpGet]
        public ActionResult<List<Orders>> GetOrders()
        {
            return orderService.GetOrders();
        }
    }
}
