using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp8.Shared;

namespace BlazorApp8.Server.Services
{
  public  interface IOrderService
    {
        Task<List<OrderDto>> GetOrders();
        void Create(OrderDto order);
    }
}
