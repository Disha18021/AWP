class Ex
 {
	public void Fun()
	{
	    // Array of integers
            int[] a = { 1, 2, 3, 4 };
            
            // Iterate through the array and print each integer
            foreach (int i in a)
            {
                System.Console.WriteLine(i);
            }
            
            // Wait for user input before closing the console window
            System.Console.ReadLine();
        }
}
class Prac1d4
{
	public static void Main(string[] args)
	{
		Ex obj=new Ex();
		obj.Fun();
	}
}