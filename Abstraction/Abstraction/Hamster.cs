using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Hamster : Animal
    {
        public Hamster()
        {
            age = 1;
            name = "Ham";
        }
        public override void Breathe()
        {
            Console.WriteLine("Hamster is breathing");
        }

        public override void Consume()
        {
            Console.WriteLine("Hamster is eating");
        }
    }
}
