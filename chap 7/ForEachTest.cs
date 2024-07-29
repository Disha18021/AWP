class Ex
{
	public void Fun()
	{
		int[] arrayInt = {11,22,33,44};
		foreach (int m in arrayInt)
		{
			System.Console.WriteLine(" "+m);
		}
		System.Console.WriteLine( );
	}
}
class ForEachTest
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}