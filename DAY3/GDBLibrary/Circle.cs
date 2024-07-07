using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDBLibrary
{
    public class Circle : Iprintable, Istorable
    {
        public void Print()
        {
            Console.WriteLine("this is Circle");
        }
        public void Store()
        {
            Console.WriteLine("this is Circle Store");
        }

    }
}
