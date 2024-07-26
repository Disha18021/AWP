class Ex
{
	public void Fun()
	{
		System.Console.WriteLine("sines of angles from 0 to 90 degrees");
		for (double theta=0.0;theta<=90.00;theta+=15)
		{
			double x = System.Math.Sin (theta * System.Math.PI/180);
			System.Console.Write("Sin" + theta);
			System.Console.WriteLine(" ={0:F4}" +x);
		}
	}
}
class MathTest
{
	public static void Main()
	{
		Ex obj= new Ex();
		obj.Fun();
	}
}