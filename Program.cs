using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound on each instance
            Console.WriteLine("Generic animal says: ");
            genericAnimal.MakeSound();
            
            Console.WriteLine("\nDog says: ");
            dog.MakeSound();
            
            Console.WriteLine("\nCat says: ");
            cat.MakeSound();

            // Demonstrate polymorphism
            Console.WriteLine("\nDemonstrating polymorphism:");
            Animal myPet = new Dog();
            Console.Write("myPet (Animal reference to a Dog) says: ");
            myPet.MakeSound();  // Calls Dog's MakeSound()

            myPet = new Cat();
            Console.Write("Now myPet (Animal reference to a Cat) says: ");
            myPet.MakeSound();  // Calls Cat's MakeSound()

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
