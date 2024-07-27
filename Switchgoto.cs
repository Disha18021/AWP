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
				goto case 2;
			case 2:
				x = y + m;
				goto default;
			default:
				x = y - m;
				break;
		}
		System.Console.WriteLine(x);
	}
}
class Switchgoto
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}