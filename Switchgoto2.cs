class Ex
{
	public void Fun()
	{
		int m,x,y;
		m=10;
		y=2;
		switch(m)
		{
			default:
				x=y-m;
				break;
			case 2:
				x= y+m;
				goto default;
			case 1:
				x=y;
				goto case 2;
		}
		System.Console.WriteLine(x);
	}
}
class Switchgoto2
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}