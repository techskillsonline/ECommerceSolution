using Infrastructure.IRepositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection svcColl, IConfiguration configuration)
        {
            svcColl.AddDbContext<DatabaseContext>(opts=>
            {
                opts.UseSqlServer(configuration.GetConnectionString("ECommerceConString"));
            });

            svcColl.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            svcColl.AddScoped<ICategoryRepository,CategoryRepository>();
            svcColl.AddScoped<IProductImageRepository,ProductImageRepository>();
            svcColl.AddScoped<IProductRepository,ProductRepository>();
            svcColl.AddScoped<ISellerRepository,SellerRepository>();
            svcColl.AddScoped<IShoppingCartRepository,ShoppingCartRepository>();
            svcColl.AddScoped<IShoppingCartItemRepository,ShoppingCartItemRepository>();

            return svcColl;
        }
    }
}

