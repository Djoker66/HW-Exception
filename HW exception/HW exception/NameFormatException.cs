using System;
using System.Collections.Generic;
using System.Text;

namespace HW_exception
{
    internal class NameFormatException:Exception
    {
        public NameFormatException(string message): base (message)
        {

        }
    }

}
