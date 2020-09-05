using System;
using System.Runtime.InteropServices;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string name = "Unknown";
            Console.WriteLine("Hello World!");
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
            while (isAlive = true) { 
            Console.WriteLine("Good. What is your name?");
                name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Alive:" + isAlive);
                break;
        }
            Console.WriteLine("You deserve a to be told happy birthday every year!");
            for (int i = 0; i <= age; i++)
            {
                Console.WriteLine("Happy birthday");
            }
            Console.WriteLine("Did you enjoy playing this game?");
            Console.WriteLine("Answer with 1 for yes and 2 for no");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Good!");
                    break;
                case 2:
                    Console.WriteLine("Nooo");
                    break;
                default:
                    Console.WriteLine("Whatever");
                    break;
            }
        }
    }
}
