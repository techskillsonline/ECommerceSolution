using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface ICategoryService
    {
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(Category newCategory);
        public Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<Category> newCategories);

        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int categoryId);

        public Task<(bool isSuccess, string message, dynamic? dataObject)> GetAllAsync();



    }
}
