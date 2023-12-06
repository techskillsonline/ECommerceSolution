using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductImage:BaseEntity
    {
        private ProductImage()
        {
            
        }

        public ProductImage(
            string productImageName,
            string productImageURL,
            string productImageTitle,
            string altText,
            int productId,
            string createdBy)
        {
            this.ProductImageName = productImageName;
            this.ProductImageURL = productImageURL;
            this.ProductImageTitle = productImageTitle;
            this.AltText = altText;
            this.ProductId = productId;
            this.Createdby = createdBy;
        }
        public string ProductImageName { get; private set; }
        public string ProductImageDescription { get; set; }
        public string ProductImageURL { get; private set; }
        public string ProductImageTitle { get; private set;}
        public string AltText { get; set; }
        public int ProductId { get; private set; }
        public Product MainProduct { get; set; }
    }
}

