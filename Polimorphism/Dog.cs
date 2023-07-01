using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Dog class Voice");
        }

        public override void Move()
        {
            Console.WriteLine("Dog class Move");
        }

        public override void Life()
        {
            Console.WriteLine("Dog class Life");
        }
    }
}
