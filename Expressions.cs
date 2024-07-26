class Ex
{
	public void Fun()
	{
		int a=10, b=5, c=8, d=2;
		float x=6.4F, y=3.0F;
		
		int answer1=a * b + c / d;
		int answer2=a * (b+c) / d;
		
		int answer3=a % c;
		float answer4=x %  y;

		bool bool1= a > b && c > d;
		bool bool2= a < b && c > d;
		bool bool3= a < b || c > d;
		bool bool4= !(a-b == c);
		
		System.Console.WriteLine("Order of Evaluation");
		System.Console.WriteLine("a*b+c/d = "+answer1);
		System.Console.WriteLine("a*(b+c)/d= "+answer2);
		
		System.Console.WriteLine("Modulo Operations");
		System.Console.WriteLine("a%c =" +answer3);
		System.Console.WriteLine("x%y =" +answer4);

		System.Console.WriteLine("Logical Operations");
		System.Console.WriteLine("a>b && c>d =" +bool1);
		System.Console.WriteLine("a<b && c>d =" +bool2);
		System.Console.WriteLine("a<d || c>d =" +bool3);
		System.Console.WriteLine("!(a-b) == c =" +bool4);
	}
}
class Expressions
{
	public static void Main()
	{
		Ex obj = new Ex();
		obj.Fun();
	}
}