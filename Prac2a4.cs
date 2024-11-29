class Temperature
{
    public void Demo()
    {
        System.Console.WriteLine("Temperature Converter");
        System.Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(System.Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 273.15;

        System.Console.WriteLine("Fahrenheit: {0}",fahrenheit);
        System.Console.WriteLine("Kelvin: {0}",kelvin);
    }
}
class Prac2a4
{
     public static void Main(string[] args)
     {
         Temperature obj = new Temperature();
         obj.Demo();
     }
}