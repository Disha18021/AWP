using System;

public class Basec
{
	public int d;
        public string Bm()
        {
            return "base class";
        }
}

public class Derived : Basec
{
        public string Dm()
        {
            return "derived class";
        }
}    


class Single_Inheritance
{
    static void Main(string[] args)
    {
        Basec b = new Basec();
        Derived d = new Derived();

        Console.WriteLine("Calling Basec.Bm(): " + b.Bm());
        Console.WriteLine("Calling Derived.Bm(): " + d.Bm());
        Console.WriteLine("Calling Derived.Dm(): " + d.Dm());
    }
}