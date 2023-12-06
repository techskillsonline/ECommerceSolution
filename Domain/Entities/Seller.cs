using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SharedKernel;

namespace Domain.Entities
{
    public class Seller:User
    {
        private Seller() { }
        public Seller(string firstName,string middleName,string lastName,string emailAddress,string phoneNumber,string createdBy) 
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Email = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.Createdby = createdBy;
            this.MiddleName = middleName;
        }
        public virtual IList<Product> Products { get; set; }
    }
}

