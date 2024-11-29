class Ex
{
	public static int factorial(int n) 
	{ 
		if (n == 0) 
			return 1; 
		return n * factorial(n - 1); 
	} 
	public void Fun()
	{
		int num=System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Factorial of {0} is {1} " ,num, factorial(num)); 
		System.Console.ReadLine();
	}
}	
class Prac2a
{
	public static void Main() 
	{ 
		Ex obj=new Ex();
		obj.Fun();	
	} 
} 

