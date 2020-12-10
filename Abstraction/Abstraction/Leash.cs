using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Leash : Accessory
    {
        public Leash()
        {
            size = 3;
            MaterialType = "Silver";
        }
        public override void Resting()
        {
            Console.WriteLine("The leash is on the floor");
        }

        public override void Working()
        {
            Console.WriteLine("The leash is securing the animal");
        }
    }
}
