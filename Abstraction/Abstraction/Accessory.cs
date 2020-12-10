using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Accessory
    {
        public int size { get; set; }
        public string MaterialType { get; set; }
        public abstract void Working();
        public abstract void Resting();
    }
}
