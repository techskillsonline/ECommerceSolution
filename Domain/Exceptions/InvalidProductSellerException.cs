using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidProductSellerException:Exception
    {
        public InvalidProductSellerException(string exceptionMessage):base(exceptionMessage)
        {
            
        }
    }
}
