using System;

class Demo
{
	public void FloydTriangle(int n)
        {
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k++ + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
}
    class Prac1f
    {
        static void Main(string[] args)
        {
	    Demo obj= new Demo();
            Console.WriteLine("Enter the range for Floyd's Triangle: ");
            int n = int.Parse(Console.ReadLine());

            obj.FloydTriangle(n);
        }

        
    }

