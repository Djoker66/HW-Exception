using System;
using System.Collections.Generic;
using System.Text;

namespace HW_exception
{
    internal class PriceFormatException:Exception
    {
        public PriceFormatException(string message) : base(message) 
        {
            
        }
    }
}
