using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions opts) : base(opts)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var productbuilder = modelBuilder.Entity<Product>();
            var sellerbuilder = modelBuilder.Entity<Seller>();
            var categorybuilder = modelBuilder.Entity<Category>();
            var productimagesbuilder = modelBuilder.Entity<ProductImage>();

            //if (productbuilder != null) 
            //{
            //    productbuilder.HasMany<ProductImage>(product => product.ProductImages).WithOne(productimage => productimage.Product);
            //}

            //if(sellerbuilder != null)
            //{
            //    sellerbuilder.HasMany<Product>(seller => seller.Products).WithOne(product => product.Seller);
            //}

            //if(categorybuilder != null)
            //{
            //    categorybuilder.HasMany<Product>(category=>category.Products).WithOne(product=>product.Category);
            //    categorybuilder.HasMany<Category>(category => category.Categories).WithOne(category => category.ParentCategory);
            //}


            modelBuilder.Entity<Category>().HasData(
                new Category("Electronics")
                {
                    CategoryDescription = "Electronics Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 1
                },
                new Category("Shoes")
                {
                    CategoryDescription = "Shoes Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 2
                },
                new Category("Cosmetics")
                {
                    CategoryDescription = "Cosmetics Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 3
                },
                new Category("Clothing")
                {
                    CategoryDescription = "Clothing Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 4
                },
                new Category("Laptops", 1)
                {
                    CategoryDescription = "Laptops Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 5
                },
                new Category("Mobiles", 1)
                {
                    CategoryDescription = "Mobiles Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 6
                },
                new Category("Tablets", 1)
                {
                    CategoryDescription = "Tablets Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 7
                },
                new Category("Running Shoes", 2)
                {
                    CategoryDescription = "Running Shoes Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 8
                },
                new Category("Boots", 2)
                {
                    CategoryDescription = "Boots Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 9
                },
                new Category("Formal Shoes", 2)
                {
                    CategoryDescription = "Formal Shoes Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 10
                },
                new Category("Casual Shoes", 4)
                {
                    CategoryDescription = "Casual Shoes Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 11
                },
                new Category("WinterWear", 4)
                {
                    CategoryDescription = "WinterWear Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 12
                },
                new Category("SummerWear", 4)
                {
                    CategoryDescription = "SummerWear Category",
                    Createdby = "rahulsinghishere@gmail.com",
                    Id = 13
                }
                );

            modelBuilder.Entity<Seller>().HasData(
                    new Seller
                    ("Rahul","Rajendra", "Singh", "rahulsinghishere@gmail.com", "01626519371", "rahulsinghishere@gmail.com")
                    { Id=1});

            modelBuilder.Entity<Product>().HasData(ProductsSeedData());
        }

        public Product[] ProductsSeedData()
        {
            Product[] products = new Product[500];
            for(int i = 0;i < 500;i++)
            {
                int randomcategoryid = Random.Shared.Next(1, 13);

                Product p = new Product($"Product_{i}",100 * randomcategoryid,1000 * randomcategoryid, 1, randomcategoryid, "rahulsinghishere@gmail.com") { Id=i+1};
                products[i] = p;
            }

            return products;
        }
    }
}






