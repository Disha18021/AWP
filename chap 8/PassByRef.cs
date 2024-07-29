class Ex
{
	static void Swap( ref int x,ref int y)
	{
		int temp = x;
		x = y;
		y = temp;
	}
	public void Fun()
	{
		int m=100;
		int n=200;
		System.Console.WriteLine("Before Swapping:");
		System.Console.WriteLine("m = "+m);
		System.Console.WriteLine("n = "+n);

		Swap(ref m,ref n);
		
		System.Console.WriteLine("After Swapping:");
		System.Console.WriteLine("m ="+m);
		System.Console.WriteLine("n ="+n);
	}
}
class PassByRef
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}
		