using Application.IServices;
using Domain.Entities;
using Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _cartrepo;

        public ShoppingCartService(IShoppingCartRepository cartRepo)
        {
            this._cartrepo = cartRepo;
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(ShoppingCart shoppingCart)
        {
            var issuccess = await this._cartrepo.AddAsync(shoppingCart);

            if(!issuccess)
            {
                return (false, "Failed", null);
            }
            return (issuccess, "Successfull", shoppingCart);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> DeleteAsync(int shoppingCartId)
        {
            var issuccess = await this._cartrepo.DeleteAsync(shoppingCartId);

            if (!issuccess)
            {
                return (false, "Failed", null);
            }
            return (issuccess, "Successfull", shoppingCartId);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int shoppingCartId)
        {
            var obj = await this._cartrepo.GetAsync(shoppingCartId);

            if (obj != null)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", obj);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetByCustomerIdAsync(int customerId)
        {
            var obj = await this._cartrepo.GetAsync(i => { return i.CustomerId == customerId; });

            if (obj != null)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", obj);
        }
    }
}


