using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            string lifeStage;
            if (age > 0 && age < 13)
            {
                lifeStage = "child";
            }
            else if (age > 13 && (age < 18 || age == 18))
            {
                lifeStage = "teenager";
            }
            else if (age < 18)
            {
                lifeStage = "adult";
            }
            else
            {
                lifeStage = "unknown";
            }
            Console.WriteLine("Are you alive?");
            string life = Console.ReadLine();
            bool isAlive = true;
            if (life == "yes")
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("You are a" + lifeStage);
            Console.WriteLine("Alive:" + isAlive);



        }
    }
}
