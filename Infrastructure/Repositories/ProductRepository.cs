﻿using Domain.Entities;
using Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext dbContext):base(dbContext)
        {
            
        }
    }
}
