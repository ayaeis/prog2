using System;
using System.Globalization;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum());
            Words();
            SortNumbers();
        }
        static int Sum()
        {
            int[] Numbers = new int[5];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("write a number to fill the list");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int SumOfList = 0;
            for (int i =0; i < Numbers.Length; i++)
            {
                  SumOfList += Numbers[i];
            }
            return SumOfList;
        }
        static void Words()
        {
            string[] TheWords = new string[5];
            for (int i=0; i< TheWords.Length; i++)
            {
                Console.WriteLine("Write a word to fill in the list");
                TheWords[i] = Console.ReadLine();
            }
            for(int i= TheWords.Length-1; i>=0; i--)
            {
                Console.WriteLine(TheWords[i]);
            }
        }
        static void SortNumbers()
        {
            int[] Digits = new int[5];
            for (int i = 0; i < Digits.Length; i++)
            {
                Console.WriteLine("write a number to fill the list");
                Digits[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The biggest number is: " + Digits.Max());
            Console.WriteLine("The smallest number is: " + Digits.Min());

        }

       
    }
}
