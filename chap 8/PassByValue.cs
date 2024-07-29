class Ex
{
	public void Change(int m)
	{
		m = m+10;
		System.Console.WriteLine( "x =" +m);
	}
	public void Fun()
	{
		int x=100;
		Change(x);
		
	}
}
class PassByValue
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}