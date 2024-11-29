using System;

    class Prac2e
    {
        // Delegate declaration
        public delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            // Input for first number
            Console.WriteLine("Enter first number:");
            string input1 = Console.ReadLine();

            // Input for second number
            Console.WriteLine("Enter second number:");
            string input2 = Console.ReadLine();

            int a, b;
            bool isNum1 = int.TryParse(input1, out a);
            bool isNum2 = int.TryParse(input2, out b);

            if (isNum1 && isNum2)
            {
                // Call PerformOperation and pass the Add and Subtract methods
                PerformOperation(Add, Subtract, a, b);
            }
            else
            {
                Console.WriteLine("Please enter valid numbers.");
            }

            Console.ReadLine();  // Keep the console open
        }

        // Addition method
        public static int Add(int x, int y)
        {
            return x + y;
        }

        // Subtraction method
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        // Method to handle operations
        public static void PerformOperation(Operation addOp, Operation subOp, int a, int b)
        {
            // Perform both addition and subtraction
            int sumResult = addOp(a, b);
            int subResult = subOp(a, b);

            Console.WriteLine("Addition Result: " + sumResult);
            Console.WriteLine("Subtraction Result: " + subResult);
        }
    }
