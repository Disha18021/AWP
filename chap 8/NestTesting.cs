class Nesting
{
	public void Largest(int m, int n)
	{
		int large= Max(m,n);
		System.Console.WriteLine(large);
	}
	int Max(int a, int b)
	{
		int x=(a>b) ? a:b;
		return(x);
	}
}
class NestTesting
{
	public static void Main(string[] args)
	{
		Nesting next= new Nesting();
		next.Largest(100,200);
	}
}