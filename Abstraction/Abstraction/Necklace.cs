using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Necklace : Accessory
    {
        public Necklace()
        {
            size = 3;
            MaterialType = "Gold";
        }
        public override void Resting()
        {
            Console.WriteLine("The necklace is in the drawer");
        }

        public override void Working()
        {
            Console.WriteLine("The necklace is on the animal's neck");
        }
    }
}

