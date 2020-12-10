using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Dog : Animal
    {
        public Dog()
        {
            age = 2;
            name = "Lucy";
        }
        public override void Breathe()
        {
            Console.WriteLine("Dog is breathing");
        }

        public override void Consume()
        {
            Console.WriteLine("Dog is eating");
        }
    }
}
