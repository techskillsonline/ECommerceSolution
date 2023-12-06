using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SharedKernel
{
    public abstract class User : BaseEntity
    {

        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string MiddleName { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }

    }
}

