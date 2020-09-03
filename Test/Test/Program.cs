using System;

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
            Console.WriteLine("Alive:" + isAlive);

        }
    }
}
