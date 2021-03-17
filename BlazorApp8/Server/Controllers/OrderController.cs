using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlazorApp8.Shared;
namespace BlazorApp8.Server.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
             _orderService = orderService;
        }
        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetOrders()
            {

            return Ok(await _orderService.GetOrders());

            }
        [HttpPost("/Create")]
     

       public void Create([FromBody] OrderDto order)
        {
            if (ModelState.IsValid)
                _orderService.Create(order);
        }


            
    }
}
