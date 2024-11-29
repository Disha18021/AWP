public class ConversionService
{
    private const double ConversionRate = 83.94; 

    public double ConvertUsdToInr(double usdValue)
    {
        return usdValue * ConversionRate;
    }
}

public class Prac2a2
{
    public static void Main()
    {
        ConversionService conversionService = new ConversionService();
        System.Console.Write("Enter amount in USD: ");
        double usdValue = System.Convert.ToDouble(System.Console.ReadLine());

        double inrValue = conversionService.ConvertUsdToInr(usdValue);
        System.Console.WriteLine("USD {0} = INR {1:0.00}", usdValue, inrValue);
    }
}
