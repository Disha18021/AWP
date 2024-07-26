class Trial1
{
	private int x;
	public void setX(int y)
	{
		x=y;
		int result=CalcSquare();
		System.Console.WriteLine(result);
	}
	private int CalcSquare()
	{
		return(x*x);
	}
}
class Trial2: Trial1
{
	public void Display(int z)
	{
		setX(z);
	}
}
class TrialClient
{
	public static void Main(string[] args)
	{
		Trial2 object1= new Trial2();
		object1.Display(3);
	}
}