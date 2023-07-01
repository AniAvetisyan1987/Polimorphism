using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("Animal class Voice");
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal class Move");
        } 
        public virtual void Life()
        {
            Console.WriteLine("Animal class Life");
        }

        public void Body()
        {
            Console.WriteLine("Animal Body");
        }
    }
}
