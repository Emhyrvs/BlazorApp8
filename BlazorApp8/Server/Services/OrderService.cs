using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp8.Shared;
namespace BlazorApp8.Server.Services
{
    public class OrderService : IOrderService
    {
        public List<OrderDto> Orders { get; set; }         
        public async Task<List<OrderDto>> GetOrders()
        {
            return new List<OrderDto>();
        }
        public void Create(OrderDto order)
        {

            Orders.Add(order);
        }


       
    }
}
