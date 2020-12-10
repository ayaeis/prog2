using System;
using System.Collections.Generic;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            var cat = new Cat();
            var dog = new Dog();
            var hamster = new Hamster();

            Console.WriteLine("Which animals do you want ? Dog, cat or hamster?");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "dog":
                    animals.Add(dog);
                    break;
                case "cat":
                    animals.Add(cat);
                    break;
                case "hamster":
                    animals.Add(hamster);
                    break;
            }
            List<Accessory> accessories = new List<Accessory>();

            var leash = new Leash();
            var necklace = new Necklace();
            Console.WriteLine("which accessory do you want? Leash or necklace?");
            var choice2 = Console.ReadLine();
            switch(choice2)
            {
                case "leash":
                    accessories.Add(leash);
                    break;
                case "necklace":
                    accessories.Add(necklace);
                    break;
            }
           foreach ( var animal in animals) {
                animal.Breathe();
                animal.Consume();
                Console.WriteLine("Animal's name is " + animal.name);
                Console.WriteLine("Animal is " + animal.age + "years");
            }
           foreach (var accessory in accessories)
            {
                accessory.Working();
                accessory.Resting();
                Console.WriteLine("Accessory's size is " + accessory.size);
                Console.WriteLine("Accessory's material type is " + accessory.MaterialType);
            }
        }
    }
}
