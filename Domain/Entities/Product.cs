using Domain.Exceptions;
using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:BaseEntity
    {
        private Product() { }
        public Product(
            string productName, 
            decimal productPrice, 
            long itemCount,
            int sellerId,
            int categoryId,
            string createdBy)
        {
            this.CategoryId = categoryId;
            if(string.IsNullOrEmpty(productName))
            {
                throw new InvalidProductNameException($"Product Name is Invalid or Empty");
            }

            this.ProductName = productName;
            if(productPrice <= 0)
            {
                throw new InvalidProductPriceException($"Product Price is Invalid for {productName}");
            }

            this.ProductPrice = productPrice;

            if(itemCount <= 0)
            {
                throw new InvalidProductItemCountException($"Product Item Count is Invalid for {productName}");
            }
            this.itemCount = itemCount;
            if (sellerId <= 0)
            {
                throw new InvalidProductSellerException($"Product Item Count is Invalid for {productName}");
            }
            this.SellerId = sellerId;
            
            this.Createdby = createdBy;
        }

        public string ProductName { get; private set; }
        public string? ProductDescription { get; set; }
        public Guid ProductSKUId { get; private init; } = Guid.NewGuid();
        public decimal ProductPrice { get; private set; }
        public long itemCount { get; private set; }
        public int SellerId { get; private set; }
        public int CategoryId { get; private set; }
        public virtual Seller Seller { get; set; }

        public virtual Category Category { get; set; }
    }
}


