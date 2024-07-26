class Ex
{
	public void Fun()
	{
		float sum;
		int i;
		sum = 0.0F;
		for (i=1;i<=10;i++)
		{
			sum = sum +1/(float)i;
			System.Console.Write("i="+i);
			System.Console.WriteLine("sum =" +sum);
		}
	}
}
class Casting
{
	public static void Main()
	{
		Ex obj= new Ex();
		obj.Fun();
	}
}