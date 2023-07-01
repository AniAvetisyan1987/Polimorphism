using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Cat class Voice");
        }

        public override void Move()
        {
            Console.WriteLine("Cat class Move");
        }

        public override void Life()
        {
            Console.WriteLine("Cat class Life");
        }

        public void Body()
        {
            Console.WriteLine("Cat Body");
        }
    }
}
