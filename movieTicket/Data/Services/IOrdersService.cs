using movieTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieTicket.Data.Services
{
    public interface IOrdersService
    {
        Task storeOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrderByUserIdAndRoleAsync(string userId,string userRole);
    }
}
