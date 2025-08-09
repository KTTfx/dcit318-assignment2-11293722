using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate Shapes
            Console.WriteLine("--- Shape Demo ---");
            Shape circle = new Circle(5.0);
            Console.WriteLine($"Area of Circle with radius 5.0: {circle.GetArea():F2}");

            Shape rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Area of Rectangle 4.0 x 6.0: {rectangle.GetArea():F2}");

            // Demonstrate IMovable interface
            Console.WriteLine("\n--- IMovable Demo ---");
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            Console.WriteLine("Calling Move() on Car:");
            car.Move();

            Console.WriteLine("\nCalling Move() on Bicycle:");
            bicycle.Move();
        }
    }
}
            myPet = new Cat();
            Console.Write("Now myPet (Animal reference to a Cat) says: ");
            myPet.MakeSound();  // Calls Cat's MakeSound()

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
