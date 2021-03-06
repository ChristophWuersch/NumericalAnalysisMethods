﻿using System;

namespace Fixed_Point_Iteration_method
{
    class Program
    {
        private static double F(double x)
        {
            return Math.Exp(x) + 1 - Math.Sqrt(9.0 - x * x);
        }

        public static double dF(double x)
        {
            return Math.Exp(x) + (x / Math.Sqrt(9.0 - x * x));
        }

        static void Main()
        {
            const double Fault = 0.00001;
            const double LeftBorder = 0;
            const double RightBorder = 1;

            Func<double, double> func = F;
            Func<double, double> funcDerivative = dF;

            Solution result = Method.FixedPointIteration(func, funcDerivative, LeftBorder, RightBorder, Fault);

            Console.WriteLine($"Approximate Root - {result.ApproximateRoot}");
            Console.WriteLine($"Number of Iterations -  {result.IterationsNumber}");

            Console.ReadKey();
        }
    }
}
