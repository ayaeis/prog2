using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Cat : Animal
    {
        public Cat()
        {
            age = 8;
            name = "Nemo";
        }
        public override void Breathe()
        {
            Console.WriteLine("Cat is breathing");
        }

        public override void Consume()
        {
            Console.WriteLine("Cat is eating");
        }
    }
}
