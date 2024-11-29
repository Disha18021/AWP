using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal  // Derived from Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Cat : Animal  // Derived from Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

class Hierarchical
{
    static void Main()
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        dog.Eat();  // Inherited from Animal
        dog.Bark();
        
        cat.Eat();  // Inherited from Animal
        cat.Meow();
    }
}
