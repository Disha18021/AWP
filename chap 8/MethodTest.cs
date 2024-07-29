public class Method
{
	public int Cube(int x)
	{
		return (x  * x * x);
	}
	public void Cube1()
	{
		int z= Cube(5);
		System.Console.WriteLine(z);

	}
}

class MethodTest
{
	public static void Main(string[] args)
	{
		Method M = new Method();
		M.Cube1();

	}
}