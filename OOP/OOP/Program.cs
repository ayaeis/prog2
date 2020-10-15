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
                Console.WriteLine("Do you want 1. Food or 2. Drink or 3. Candy");
                var choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("What food do you want?");
                    var food = new Mat() { _matTyp = Console.ReadLine() };
                    kund._shoppingCart.Add(food);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("which drink do you want");
                    var drink = new Drycka() { _dryckTyp = Console.ReadLine() };
                    kund._shoppingCart.Add(drink);

                }
                else if (choice == 3)
                {
                    Console.WriteLine("Which candy do you want");
                    var candy = new Godis() { _godisTyp = Console.ReadLine() };
                    kund._shoppingCart.Add(candy);
                }
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
