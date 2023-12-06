using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IShoppingCartItemService
    {
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(ShoppingCartItem item);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<ShoppingCartItem> items);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> UpdateAsync(ShoppingCartItem item);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> DeleteAsync(int itemId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int itemId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAllAsync();
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(Func<ShoppingCartItem, bool> condition);
    }
}

