using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidCategoryException:Exception
    {
        public InvalidCategoryException(string exceptionMessage):base(exceptionMessage)
        {
            
        }
    }
}

