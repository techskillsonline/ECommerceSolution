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
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryrepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryrepository = categoryRepository;
        }
        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(Category newCategory)
        {
            bool issuccess = await this._categoryrepository.AddAsync(newCategory);
            if (issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", newCategory);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> AddAsync(List<Category> newCategories)
        {
            bool issuccess = await this._categoryrepository.AddAsync(newCategories);
            if (issuccess)
            {
                //Tuple<(bool, string, dynamic)> t = new Tuple<(bool, string, dynamic)>();

                return (issuccess, "Successfull", newCategories);
            }
            return (false, "Failed", null);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAllAsync()
        {
            var lst = await this._categoryrepository.GetAllAsync();
            if(lst == null)
            {
                return (false, "No Records Found", null);
            }
            return (true, "Successfull", lst);
        }

        public async Task<(bool isSuccess, string message, dynamic? dataObject)> GetAsync(int categoryId)
        {
            var result = await this._categoryrepository.GetAsync(categoryId);
            if(result == null) 
            {
                return (false, "No Records Found", null);
            }

            return (true, "Successfull", result);
        }
    }
}
