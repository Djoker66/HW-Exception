using System;
using System.Collections.Generic;
using System.Text;

namespace HW_exception
{
    internal class RamFormatException: Exception
    {
        public RamFormatException(string message): base(message)
        {

        }
    }
}
