using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingCart:BaseEntity
    {
        private ShoppingCart() { }
        public ShoppingCart(int customerId)
        {
            this.CustomerId = customerId;
        }
        public int CustomerId { get; set; }

        public virtual List<ShoppingCartItem>? Items { get; set; }

    }

    public class ShoppingCartItem:BaseEntity
    {
        private ShoppingCartItem() { }
        public ShoppingCartItem(int productId,int productQuantity,decimal unitPrice,int shoppingCartId)
        {
            this.ProductId = productId;
            this.ProductQuantity = productQuantity;
            this.UnitPrice = unitPrice;
            this.ShoppingCartId = shoppingCartId;
        }

        public int ProductId { get; private set; }
        public int ProductQuantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalItemPrice 
        { 
            get
            {
                return UnitPrice * ProductQuantity;
            } 
        }

        public int ShoppingCartId { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }

    }
}


