using System;
class Demo
{
	public void Fun()
	{
		try
        	{
            		// Get input from the user
            		Console.Write("Enter the first number: ");
            		int num1 = int.Parse(Console.ReadLine());

            		Console.Write("Enter the second number: ");
            		int num2 = int.Parse(Console.ReadLine());

            		// Perform division
            		int result = num1 / num2;
           	 	Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, result);
       		}
        	catch (DivideByZeroException)
        	{
            		// Handle division by zero
            		Console.WriteLine("Error: Cannot divide by zero!");
        	}
        	catch (FormatException)
        	{
            		// Handle invalid input
            		Console.WriteLine("Error: Please enter valid numbers.");
        	}
        	catch (Exception ex)
        	{
            		// Handle any other exceptions
            		Console.WriteLine("An unexpected error occurred: " + ex.Message);
        	}
        	finally
        	{
            		// Code in this block always runs
            		Console.WriteLine("End of the program.");
        	}
	}
	
}
class Prac2cc2
{
    static void Main(string[] args)
    {
        Demo obj = new Demo();
	obj.Fun();
    }
}
