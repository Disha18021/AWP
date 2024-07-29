class Ex
{
	public void Fun()
	{
		int row, column, y;
		row=1;
		System.Console.WriteLine("Multiplication Table \n");
		
		do
		{
			column =1;
			do
			{
				y=row*column;
				System.Console.WriteLine(" " +y);
				column = column+1;
			}
			while(column<=5);
			System.Console.WriteLine("\n");
			row=row+1;
		}
		while(row<=5);
	}
}
class DoWhileTest
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}