using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IProductService
    {
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(Product newProduct);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<Product> newProduct);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> UpdateAsync(Product editProduct);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> DeleteAsync(int productId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int productId);

        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetByCategoryIdAsync(int categoryId);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAllAsync();
        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(Func<Product,bool> condition);
    }
}

