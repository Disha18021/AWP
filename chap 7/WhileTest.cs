class Ex
{
	public void Fun()
	{
		int n=1;
		while (n<=10)
		{
			if(n%2==0)
			{
				n++;
			}
			else
			{
				System.Console.WriteLine(" " +n);
				n++;
			}	
		}
	}
}
class WhileTest
{
	public static void Main(string[] args)
	{
		Ex obj= new Ex();
		obj.Fun();
	}
}