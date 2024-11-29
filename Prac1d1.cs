class Ex
{
	public void Fun()
	{
		int a = 0, b = 1, c;
		System.Console.Write("Enter the range: ");
                int end = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Fibonacci Series till the range "+end);
                System.Console.WriteLine(a + " \n" + b + " ");
                for (int i = 2; i < end; i++)
                {
                   c = a + b;
                   System.Console.WriteLine(c);
                    a = b;
                    b = c;
                }
		System.Console.ReadLine();
	}
}
class Prac1d1
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
         }
}

	