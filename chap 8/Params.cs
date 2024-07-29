class Ex
{
	static void Parray (params int[] arr)
	{
		System.Console.WriteLine("Array elements are:");
		foreach (int i in arr)
			System.Console.WriteLine(" "+i);
		System.Console.WriteLine( );
	}
	public void Fun()
	{
		int[] x= {11,22,33};
		Parray(x);
		Parray();
		Parray(100,200);
	}
}
class Params
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}	