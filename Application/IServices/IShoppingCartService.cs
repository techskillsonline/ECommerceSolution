using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IShoppingCartService
    {
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(ShoppingCart newCart);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetByCustomerIdAsync(int customerId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int shoppingCartId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> DeleteAsync(int shoppingCartId);
    }
}

