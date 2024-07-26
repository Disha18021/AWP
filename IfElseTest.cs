class Ex
{
	public void Fun()
	{
		int[] number = { 50,65,56,71,81 };
		int even = 0, odd = 0;
		for(int i=0;i<number.Length;i++)
		{
			if((number[i] % 2)==0)
			{
				even += 1;
			}
			else
			{
				odd += 1;
			 }
			System.Console.WriteLine("Even Numbers : " +even);
			System.Console.WriteLine("Odd Numbers : " +odd);
		}
	}
}
class IfElseTest
{
	public static void Main(string[] args)
	{
		Ex obj= new Ex();
		obj.Fun();
	}
}