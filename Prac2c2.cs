/*using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                // Intentionally causing a divide-by-zero error
                int result = 100 / number;

                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                // Handling a divide by zero exception
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            catch (FormatException ex)
            {
                // Handling invalid input exception
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine($"Exception Details: {ex.Message}");
            }
            finally
            {
                // This block will always run, regardless of exceptions
                Console.WriteLine("End of program.");
            }

            Console.ReadLine();
        }
    }
}*/

using System;

class CustomException : Exception
{
    public CustomException(string msg)
        : base(msg)
    { 
    }
}

class X_handle

{
    public void Fun()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        
        int num;
        try
        {
            num = int.Parse(input);
            if (num < 0)
                throw new CustomException("Negative number");
            else
                Console.WriteLine("Positive number");
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

class Prac2c2
{
	public static void Main(string[] args)
	{
		X_handle obj = new X_handle();
		obj.Fun();
	}
}