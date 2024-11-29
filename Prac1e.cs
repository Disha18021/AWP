using System;

class Demo
{
	public void Fun()
	{
		Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            string division = (num2 != 0) ? (num1 / num2).ToString() : "undefined (cannot divide by zero)";

            Console.WriteLine("\nResults:");
            Console.WriteLine("Addition: {0}",addition);
            Console.WriteLine("Subtraction: {0}",subtraction);
            Console.WriteLine("Multiplication: {0}",multiplication);
            Console.WriteLine("Division: {0}",division);
	}
}
    class Prac1e
    {
        static void Main(string[] args)
        {
            Demo obj= new Demo();
	    obj.Fun();
        }
    }

