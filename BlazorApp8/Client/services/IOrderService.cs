using BlazorApp8.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp8.Client.services
{
    public interface IOrderService
    {
        List<OrderDto> Orders { get; set; }


        Task LoadOrders();
        Task CreateOrder(OrderDto orderDto);

         
    }
}
