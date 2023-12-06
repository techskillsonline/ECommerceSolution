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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(Product newProduct)
        {
            bool issuccess = await this._productRepository.AddAsync(newProduct);
            if(issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", newProduct);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<Product> newProduct)
        {
            bool issuccess = await this._productRepository.AddAsync(newProduct);
            if (issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", newProduct);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool, string, dynamic?)> DeleteAsync(int productId)
        {
            bool issuccess = await this._productRepository.DeleteAsync(productId);
            if (issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", null);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool, string, dynamic?)> GetAllAsync()
        {
            IEnumerable<Product> lst = await this._productRepository.GetAllAsync();
            if (lst != null)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (true, "Successfull", lst);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool, string, dynamic?)> GetAsync(int productId)
        {
            Product? obj = await this._productRepository.GetAsync(productId);
            if (obj != null)
            {
                return (true, "Successfull", obj);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool, string, dynamic?)> GetAsync(Func<Product, bool> condition)
        {
            IEnumerable<Product> lst = await this._productRepository.GetAsync(condition);
            if (lst != null)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (true, "Successfull", lst);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetByCategoryIdAsync(int categoryId)
        {
            IEnumerable<Product> lst = await this._productRepository.GetAsync(product=>product.CategoryId == categoryId);
            if (lst != null)
            {
                return (true, "Successfull", lst);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool, string, dynamic?)> UpdateAsync(Product editProduct)
        {
            bool issuccess = await this._productRepository.UpdateAsync(editProduct);
            if (issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", editProduct);
            }
            return (false, "Failed", null);
        }
    }
}
