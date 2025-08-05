namespace InheritanceDemo
{
    // Derived class Cat inheriting from Animal
    public class Cat : Animal
    {
        // Override the MakeSound method from the base class
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
