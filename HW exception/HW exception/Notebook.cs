using System;
using System.Collections.Generic;
using System.Text;

namespace HW_exception
{
    internal class Notebook:Product
    {

        public byte RAM = 4;

        public Notebook(string Name, double Price) : base(Name, Price)
        {

        }

        public Notebook(string Name, double Price, byte Ram) : base(Name, Price)
        {
            this.RAM = Ram;
        }


    }
}
