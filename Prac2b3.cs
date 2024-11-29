using System;

class ADD
{
    int x, y;
    double f;
    string s;

    // Constructor for int and double
    public ADD(int a, double b)
    {
        x = a;
        f = b;
    }

    // Constructor for int and string
    public ADD(int a, string b)
    {
        y = a;
        s = b;
    }

    // Method to display the sum of int and double
    public void show()
    {
        Console.WriteLine("1st constructor (int + double): {0}", (x + f));
    }

    // Method to display concatenation of int and string
    public void show1()
    {
        Console.WriteLine("2nd constructor (int + string): {0}", (s + y));
    }
}

class Prac2b3
{
    public static void Main(string[] args)
    {
        // Taking user input for the first constructor (int + double)
        Console.Write("Enter an integer value: ");
        int intInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a double value: ");
        double doubleInput = Convert.ToDouble(Console.ReadLine());

        ADD g = new ADD(intInput, doubleInput);
        g.show();

        // Taking user input for the second constructor (int + string)
        Console.Write("Enter another integer value: ");
        int intInput2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a string value: ");
        string stringInput = Console.ReadLine();

        ADD q = new ADD(intInput2, stringInput);
        q.show1();
    }
}
