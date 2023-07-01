using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class B : A
    {
        public override void Method()
        {
            Console.WriteLine("This is B Method");
        }

        public void StandardMethod()
        {
            Console.WriteLine("this is B class StandardMethod");
        }
    }
}
