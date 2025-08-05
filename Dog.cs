namespace InheritanceDemo
{
    // Derived class Dog inheriting from Animal
    public class Dog : Animal
    {
        // Override the MakeSound method from the base class
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
