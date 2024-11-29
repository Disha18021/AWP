class Temp  
{   
	public static void Main(string[] args)   
        {   
		 
		double a=System.Convert.ToDouble(args[0]);
		double Celsius =((a - 32)/7.58); 
		System.Console.WriteLine("{0} c",Celsius );
        }
}  