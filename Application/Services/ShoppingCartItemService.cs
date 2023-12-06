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
    public class ShoppingCartItemService : IShoppingCartItemService
    {
        private readonly IShoppingCartItemRepository _shoppingcartitemrepository;

        public ShoppingCartItemService(IShoppingCartItemRepository shoppingCartItemRepository)
        {
            this._shoppingcartitemrepository = shoppingCartItemRepository;
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(ShoppingCartItem item)
        {
            var isssuccess = await this._shoppingcartitemrepository.AddAsync(item);
            if(!isssuccess)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", item);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<ShoppingCartItem> items)
        {
            var isssuccess = await this._shoppingcartitemrepository.AddAsync(items);
            if (!isssuccess)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", items);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> DeleteAsync(int itemId)
        {
            var issuccess = await this._shoppingcartitemrepository.DeleteAsync(itemId);

            if (!issuccess)
            {
                return (false, "Failed", null);
            }
            return (issuccess, "Successfull", itemId);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAllAsync()
        {
            var lst = await this._shoppingcartitemrepository.GetAllAsync();

            if (lst != null)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", lst);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int itemId)
        {
            var obj = await this._shoppingcartitemrepository.GetAsync(itemId);

            if (obj != null)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", obj);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(Func<ShoppingCartItem, bool> condition)
        {
            var obj = await this._shoppingcartitemrepository.GetAsync(condition);

            if (obj != null)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", obj);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> UpdateAsync(ShoppingCartItem item)
        {
            var isssuccess = await this._shoppingcartitemrepository.UpdateAsync(item);
            if (!isssuccess)
            {
                return (false, "Failed", null);
            }
            return (true, "Successfull", item);
        }
    }
}

