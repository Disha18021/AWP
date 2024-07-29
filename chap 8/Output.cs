class Ex
{
	static void Square(int x, out int y)
	{
		y = x*x;
	}
	public void Fun()
	{
		int m;
		Square (10,out m);
		System.Console.WriteLine("m ="+m);
	}
}
class Output
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}