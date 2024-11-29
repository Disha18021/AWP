using System;
class Ex
{
    // Prints roots of quadratic equation ax^2 + bx + c
	public static void findRoots(int a, int b, int c)
	{
        	if (a == 0)
        	{
            		Console.WriteLine("Invalid: 'a' cannot be zero in a quadratic equation.");
            		return;
        	}

	        int d = b * b - 4 * a * c;
        	double sqrt_val = Math.Sqrt(Math.Abs(d));

	        if (d > 0)
        	{
            		Console.WriteLine("Roots are real and different:");
            		Console.WriteLine((-b + sqrt_val) / (2 * a));
            		Console.WriteLine((-b - sqrt_val) / (2 * a));
        	}
        	else if (d == 0)
        	{
            		Console.WriteLine("Roots are real and same:");
            		Console.WriteLine(-b / (2.0 * a));
        	}
        	else
        	{
            		double realPart = -b / (2.0 * a);
            		double imaginaryPart = sqrt_val / (2 * a);
            		Console.WriteLine("Roots are complex:");
           		Console.WriteLine("{0} + {1}i", realPart, imaginaryPart);
            		Console.WriteLine("{0} - {1}i", realPart, imaginaryPart);
        	}
	}
	public void Fun()
	{
        	Console.WriteLine("Enter coefficients (a, b, c) of the quadratic equation ax^2 + bx + c:");
        	int a = Convert.ToInt32(Console.ReadLine());
        	int b = Convert.ToInt32(Console.ReadLine());
        	int c = Convert.ToInt32(Console.ReadLine());

	        // Function call
        	findRoots(a, b, c);
        
        	Console.ReadLine(); // Keep console window open
	}
}

class Prac2a3
{
	public static void Main()
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}
