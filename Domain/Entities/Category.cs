using Domain.Exceptions;
using Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category:BaseEntity
    {
        private Category() { }
        public Category(string categoryName,int? parentCategoryId=null)
        {
            if(string.IsNullOrWhiteSpace(categoryName))
            {
                throw new InvalidCategoryException($"Invalid Categoryname");
            }
            this.CategoryName = categoryName;
            this.ParentCategoryId = parentCategoryId;
        }
        public string CategoryName { get; private set; }
        public string CategoryDescription { get; set; }
        public int? ParentCategoryId { get; private set; }
        public Category? ParentCategory { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Category> Categories { get; set;}

        [JsonIgnore]
        public virtual IEnumerable<Product> Products { get; set;}
    }
}

