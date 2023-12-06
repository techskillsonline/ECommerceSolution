using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidProductNameException:Exception
    {
        public InvalidProductNameException(string exceptionMessage):base(exceptionMessage) 
        {

        }
        
    }
}

