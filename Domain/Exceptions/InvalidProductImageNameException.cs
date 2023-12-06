using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidProductImageNameException:Exception
    {
        public InvalidProductImageNameException(string exceptionMessage):base(exceptionMessage) { }
        
    }

    public class ProductIdNotProvidedForImage:Exception
    {
        public ProductIdNotProvidedForImage(string exceptionMessage):base(exceptionMessage) { }
    }

    public class ImageURLNotProvidedForProductImage : Exception
    {
        public ImageURLNotProvidedForProductImage(string exceptionMessage) : base(exceptionMessage) { }
    }
}

