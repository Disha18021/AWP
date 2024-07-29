class Ex
{
	public void Fun()
	{
		int n =10;
		while (n<200)
		{
			if(n<50)
			{
				System.Console.WriteLine(" " +n);
				n=n+10;
				continue;
			}
			if(n==50)
			{
				System.Console.WriteLine( );
					n=n+10;
					continue;
			}
			if(n>90) break;
				System.Console.WriteLine(" "+n);
				n=n+10;
		}
		System.Console.WriteLine( );
	}
}
class ContinueBreak
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}