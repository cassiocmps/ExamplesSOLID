public class Animal
{
    public virtual void GetName()
    {
        Console.WriteLine("I'm a animal!");
    }
}

public class Dog : Animal
{
    public override void GetName()
    {
        Console.WriteLine("I'm a dog!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        Animal animal2 = new Dog();

        // Using a Animal instance or a Dog instance does not change how to use its methods
        animal1.GetName();
        animal2.GetName();
    }
}
