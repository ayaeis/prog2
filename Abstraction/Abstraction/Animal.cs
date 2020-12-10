using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Animal
    {
        public int age { get; set; }
        public string name { get; set; }
        public abstract void Consume();
        public abstract void Breathe();
    }
}
