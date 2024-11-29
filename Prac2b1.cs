class AreaCalculator
{
	public double CalculateArea(double sideLength)
	{
        	return sideLength * sideLength;
    	}

  
    	public double CalculateArea(double length, double width)
    	{
        	return length * width;
    	}
	public void Fun()
	{
        	AreaCalculator calculator = new AreaCalculator();

        
        	System.Console.WriteLine("Enter the side length of the square:");
        	double sideLength = System.Convert.ToDouble(System.Console.ReadLine());

        
        	double areaSquare = calculator.CalculateArea(sideLength);
        	System.Console.WriteLine("Area of the square with side length {0}: {1}",sideLength,areaSquare);

      
        	System.Console.WriteLine("\nEnter the length of the rectangle:");
        	double length = System.Convert.ToDouble(System.Console.ReadLine());
        	System.Console.WriteLine("Enter the width of the rectangle:");
        	double width = System.Convert.ToDouble(System.Console.ReadLine());

        	double areaRectangle = calculator.CalculateArea(length, width);
        	System.Console.WriteLine("Area of the rectangle with length {0} and width {1}: {2}",length,width,areaRectangle );

        	System.Console.ReadLine();
	}
}

class Prac2b1
{
    public static void Main(string[] args)
    {
	AreaCalculator obj= new AreaCalculator();
	obj.Fun();
    }
}
