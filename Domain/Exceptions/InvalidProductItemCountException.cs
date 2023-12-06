using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidProductItemCountException:Exception
    {
        public InvalidProductItemCountException(string exceptionMessage):base(exceptionMessage) { }
    }
}

