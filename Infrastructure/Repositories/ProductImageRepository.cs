using Domain.Entities;
using Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductImageRepository:GenericRepository<ProductImage>,IProductImageRepository
    {
        public ProductImageRepository(DatabaseContext dbContext):base(dbContext)
        {
            
        }
    }
}
