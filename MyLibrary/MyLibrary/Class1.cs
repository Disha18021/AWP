﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrary
{
    public class Class1
    {
        public class MathOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public double Divide(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Division by zero is not allowed.");
                return (double)a / b;
            }
        }
    }
}