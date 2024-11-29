interface ICalculator
{
    int Add(int a, int b);
}

class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}

class Prac2b4
{
    static void Main()
    {
        System.Console.Write("Enter the first number: ");
        int number1 = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter the second number: ");
        int number2 = System.Convert.ToInt32(System.Console.ReadLine());

        ICalculator calculator = new Calculator();
        int result = calculator.Add(number1, number2);
        System.Console.WriteLine("The sum of {0} and {1} is: {2}", number1, number2, result);
    }
}