using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please write a name. Number: " + i++);
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("The names will now be printed");
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
