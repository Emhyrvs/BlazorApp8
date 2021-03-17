using BlazorApp8.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BlazorApp8.Client.services
{
    public class OrderService:IOrderService
    {
        private readonly HttpClient _http;

        public List<OrderDto> Orders { get; set; } = new List<OrderDto>();

        public OrderService(HttpClient http)
        {
            _http = http;
        }
        public  async Task LoadOrders()
        {
            Orders = await _http.GetFromJsonAsync<List<OrderDto>>("api/Order");
         }

        public async Task CreateOrder(OrderDto order)
        {
            
    var a   =  await _http.PostAsJsonAsync("api/Order/Create", order);
        }

        
    }
}
