using System;

class A
{
    public void Show()
    {
        Console.WriteLine( "first base class");
    }
}

class B : A
{
    public void Show1()
    {
        Console.WriteLine( "second base class");
    }
}

class C : B
{
    public void Show2()
    {
        Console.WriteLine("derived class");
    }
}

class Multilevel_Inheritance
{
    static void Main(string[] args)
    {
        C obj = new C();
        obj.Show();
        obj.Show1();
	obj.Show2();
    }
}