class Ex
{
	public void Fun()
	{
		int m,x,y;
		m=10;
		y=2;
		switch(m)
		{
			case 1:
				x = y;
				break;
			case 2:
				x = y + m;
				break;
			default:
				x = y - m;
				break;
		}
		System.Console.WriteLine(x);
	}
}
class Switch1
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}