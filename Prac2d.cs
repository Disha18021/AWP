using System;

class Demo
{
	public void Fun()
	{
		Console.WriteLine("Enter the value:");
            string input = Console.ReadLine();

            int number;
            bool isNumeric = int.TryParse(input, out number);

            if (isNumeric)
            {
                object boxValue = number;  // Boxing
                int unboxValue = (int)boxValue;  // Unboxing

                Console.WriteLine("Box value: " + boxValue + " Unbox value: " + unboxValue);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.ReadLine();  // Keep the console open
	}
}

    class Prac2d
    {
        static void Main(string[] args)
        {
            Demo obj=new Demo();
	    obj.Fun();
        }
    }

