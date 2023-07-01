using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Bird : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Bird class Voice");
        }

        public override void Move()
        {
            Console.WriteLine("Bird class Move");
        }

        public override void Life()
        {
            Console.WriteLine("Bird class Life");
        }
    }
}
