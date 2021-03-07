using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class Variables
    {
        public static double SolveTheEquation(double a, double b)
        {
            return ((5 * a + b * b) / (b - a));
        }
        public static void ChangePlaces(double a, double b)
        {
            double c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a} {b}");
        }
        public static int DivisionAndRemainder(int a, int b)
        {
            int x = a / b;
            int d = a % b;
            return x;
        }
        public static double hw4(double a, double b, double c)
        {
            return (c - b) / a;
        }
        public static string hw5(double x1, double x2, double y1, double y2)
        {
            //Console.WriteLine("введите x1");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("введите x2");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("введите y1");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("введите y2");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            double aa = (y2 - y1) / (x2 - x1);
            double bb = (((x1 * (-1) * (y2 - y1)) + (y1 * (x2 - x1))) / (x2 - x1));
            string xx = ($"y={aa}x+{bb}");
            return xx;
        }

    }
}
