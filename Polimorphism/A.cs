using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class A
    {
        public virtual void Method()
        {
            Console.WriteLine("this is A class method");
        }

        public void StandardMethod()
        {
            Console.WriteLine("this is A class StandardMethod");
        }
    }
}
