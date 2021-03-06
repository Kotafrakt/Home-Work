using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class Variables
    {
        public static double SolveTheEquation(double a, double b)
        {
            if (a == b)
            {
                throw new ArgumentException("нельзя делить на 0");
            }
            return ((5 * a + b * b) / (b - a));
        }
        public static string ChangePlaces(double a, double b)
        {
            double c = a;
            a = b;
            b = c;
            return ($"{a} {b}");
        }
        public static double[] DivisionAndRemainder(int a, int b)
        {
            if (b==0)
            {
                throw new ArgumentException("нельзя делить на 0");
            }
            int x = a / b;
            int d = a % b;
            return new double[] { x,d };
        }
        public static double SolveLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == c)
                {
                    throw new ArgumentNullException("x может быть любым");
                }
                else 
                {
                    throw new Exception("Не имеет решения");
                }
            }
            return (c - b) / a;
        }
        public static string FindingStraight(double x1, double x2, double y1, double y2)
        {
            string xx;
            if (x1 == x2)
            {
                 xx = ("x=0");
            }
            else
            {
                double aa = (y2 - y1) / (x2 - x1);
                double bb = (((x1 * (-1) * (y2 - y1)) + (y1 * (x2 - x1))) / (x2 - x1));
                xx = ($"y={aa}x+{bb}");
            }
            return xx;
        }
    }
}
