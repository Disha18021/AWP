using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hirarchical
{
    class Animal
    {
        public string Eat()
        {
            string s="Animal is eating.";
            return s;
        }
    }

    class Dog : Animal  // Derived from Animal
    {
        public string Bark()
        {
            string p="Dog is barking.";
            return p;
        }
    }

    class Cat : Animal  // Derived from Animal
    {
        public string Meow()
        {
            string g="Cat is meowing.";
            return g;
        }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        Button b1;
        protected void Page_Load(object sender, EventArgs e)
        {
            b1 = new Button();
            b1.Click += button_1;
            b1.Text = "click";
            this.form1.Controls.Add(b1);
        }
        protected void button_1(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Response.Write(dog.Eat() + "</br>");  // Inherited from Animal
            Response.Write(dog.Bark() + "</br>");

            Response.Write(cat.Eat() + "</br>");  // Inherited from Animal
            Response.Write(cat.Meow() );
        }
    }
}