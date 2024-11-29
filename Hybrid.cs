using System;

class Animal  // Base class
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

interface IFlyable
{
    void Fly();
}

class Bird : Animal, IFlyable  // Combination of single inheritance and interface
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

class Dog : Animal  // Hierarchical Inheritance (Animal -> Dog, Animal -> Bird)
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Hybrid
{
    static void Main()
    {
        Bird bird = new Bird();
        bird.Eat();  // Inherited from Animal
        bird.Fly();  // Implemented from IFlyable
        
        Dog dog = new Dog();
        dog.Eat();   // Inherited from Animal
        dog.Bark();
    }
}
