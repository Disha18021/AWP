using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hybrid
{
    class Animal  // Base class
    {
        public string Eat()
        {
            string s = "Animal is eating.";
            return s;
        }
    }

    interface IFlyable
    {
        string Fly();
    }

    class Bird : Animal, IFlyable  // Combination of single inheritance and interface
    {
        public string Fly()
        {
            string p = "Bird is flying.";
            return p;
        }
    }

    class Dog : Animal  // Hierarchical Inheritance (Animal -> Dog, Animal -> Bird)
    {
        public string Bark()
        {
            string g = "Dog is barking.";
            return g;
        }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        protected void Page_Load(object sender, EventArgs e)
        {
            b1 = new Button();
            b1.Text = "Click";
            b1.Click += b1_Click;
            this.form1.Controls.Add(b1);
        }
        protected void b1_Click(object sender, EventArgs e)
        {
            Bird bird = new Bird();
            Response.Write(bird.Eat() + "</br>");  // Inherited from Animal
            Response.Write(bird.Fly() + "</br>");  // Implemented from IFlyable

            Dog dog = new Dog();
            Response.Write(dog.Eat() + "</br>");   // Inherited from Animal
            Response.Write(dog.Bark() + "</br>");
        }
    }
}
/*
public class Person
{
    public string Name { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }
}

public class Employee : Person
{
    public int EmployeeId { get; set; }
}

public interface IManager
{
    void AssignTask();
}

public class Manager : Employee, IManager
{
    public void AssignTask()
    {
        Console.WriteLine("Task assigned");
    }
}
*/