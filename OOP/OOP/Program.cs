using System;

namespace OOP
{
    class Program
    {
        private static bool shopping;

        static void Main(string[] args)
        {
            var kund = new Kund();
            Console.WriteLine("What is your name?");
            kund._name = Console.ReadLine();

            Console.WriteLine("Do you wanna shop?");
            string answer = Console.ReadLine();
            bool shopping;
            if (answer == "yes")
            {
                shopping = true;
            }
            else
            {
                shopping = false;
            }
            while (shopping == true)
            {
                var produkt = new Produkt();
                Console.WriteLine("Write your  wanted item");
                produkt._produktTyp = Console.ReadLine();

                kund._shoppingCart.Add(produkt);
                Console.WriteLine("do you want to add another item?");
                string answer2 = Console.ReadLine();
                if ( answer2 == "yes")
                {
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("This is ur cart");
            Console.WriteLine(kund._shoppingCart);
        }
    }
}
