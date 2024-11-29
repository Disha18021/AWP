using System;

// Define delegate
public delegate void MathOperationEventHandler(int a, int b);

// Publisher class
public class Calculator
{
    // Declare events for addition and subtraction
    public event MathOperationEventHandler OnAdd;

    // Method to trigger addition event
    public void Add(int a, int b)
    {
        if (OnAdd != null)
        {
            OnAdd(a, b);
        }
    }
}

// Subscriber class
public class MathHandler
{
    // Event handler for addition
    public void HandleAddition(int a, int b)
    {
        Console.WriteLine("Addition: {0} + {1} = {2}", a, b, a+b );
    }
}

// Main program
class Prac2c1
{
    static void Main(string[] args)
    {
        // Create instances of publisher and subscriber
        Calculator calculator = new Calculator();
        MathHandler handler = new MathHandler();

        // Subscribe to events
        calculator.OnAdd += handler.HandleAddition;

        // Get user input for the numbers
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        calculator.Add(num1, num2);
       
    }
}
