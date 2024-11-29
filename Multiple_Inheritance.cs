using System;
interface A 
{
    void Method1();
}
 
interface B
{
    void Method2();
}
 
class C : A, B 
{
    public void Method1() 
    {
        Console.WriteLine("Method1 is called.");
    }
 
    public void Method2() 
    {
        Console.WriteLine("Method2 is called.");
    }
}
class Multiple_Inheritance
{
    public static void Main(string[] args)
    {
         C obj = new C();
         obj.Method1();
         obj.Method2();
    }
}