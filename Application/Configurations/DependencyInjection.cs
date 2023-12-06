using Application.IServices;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection svcColl) 
        {
            svcColl.AddScoped<ICategoryService, CategoryService>();
            svcColl.AddScoped<IProductService, ProductService>();
            svcColl.AddScoped<IShoppingCartService, ShoppingCartService>();
            svcColl.AddScoped<ShoppingCartItemService, ShoppingCartItemService>();

            return svcColl;
        }
    }
}

