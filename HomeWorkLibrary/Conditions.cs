using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class conditions
    {
        public static double СompareAndSolve(double a, double b)
        {
            double c = 0;
            if (a > b)
            {
                c = a + b;
            }
            else if (a == b)
            {
                c = a * b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            return c;
        }
        public static string FindingAQuarter(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                throw new ArgumentException("точка лежит на оси");
            }
            string s;
            if (x > 0)
            {
                if (y > 0)
                {
                    s = "I четверть";
                }
                else
                {
                    s = ("IV четверть");
                }
            }
            else
            {
                if (y > 0)
                {
                    s = ("II четверть");
                }
                else
                {
                    s = ("III четверть");
                }
            }
            return s;
        }
        public static string FindingOfMax(double a, double b, double c)
        {
            string s;
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        s = ($"{c} {b} {a}");
                    }
                    else
                    {
                        s = ($"{b} {c} {a}");
                    }
                }
                else
                {
                    s = ($"{b} {a} {c}");
                }
            }
            else if (a > c)
            {
                s = ($"{c} {a} {b}");
            }
            else if (b > c)
            {
                s = ($"{a} {c} {b}");
            }
            else
            {
                s = ($"{a} {b} {c}");
            }
            return s;
        }
        public static double[] SolutionOfAquadraticEquation(double a, double b, double c)
        {
            if(a==0)
            {
                throw new ArgumentException("a=0");
            }
            double d = b * b - 4 * a * c;
            double x1;
            double x2;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return new double[2] { x1, x2 };
            }
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                return new double[1] { x1 };
            }
            else
            {
                return new double[0];   
            }
            
        }
        public static string TranslateIntoLettersint(int a)
        {
            if (a>99||a<10)
            {
                throw new ArgumentException("a двухзначное");
            }
            string s = "";
            string ss = "" ;
            int c = a / 10;
            int b = a % 10;
            if (a < 20)
            {
                switch (a)
                {
                    case 11:
                        s = ("Одинадцать");
                        break;
                    case 12:
                        s = ("Двенадцать");
                        break;
                    case 13:
                        s = ("Тринадцать");
                        break;
                    case 14:
                        s = ("Четырнадцать");
                        break;
                    case 15:
                        s = ("Пятнадцать");
                        break;
                    case 16:
                        s = ("Шестнадцать");
                        break;
                    case 17:
                        s = ("Семнадцать");
                        break;
                    case 18:
                        s = ("Восемнадцать");
                        break;
                    case 19:
                        s = ("Девятнадцать");
                        break;
                }
            }
            else
            {
                switch (c)
                {
                    case 2:
                        s = ("Двадать ");
                        break;
                    case 3:
                        s = ("Тридацать ");
                        break;
                    case 4:
                        s = ("Сорок ");
                        break;
                    case 5:
                        s = ("Пятьдесят ");
                        break;
                    case 6:
                        s = ("Шестьдесят ");
                        break;
                    case 7:
                        s = ("Семьдесят ");
                        break;
                    case 8:
                        s = ("Восемьдесят ");
                        break;
                    case 9:
                        s = ("Девяносто ");
                        break;
                }
                switch (b)
                {
                    case 0:
                        ss = ("");
                        break;
                    case 1:
                        ss = ("один");
                        break;
                    case 2:
                        ss = ("два");
                        break;
                    case 3:
                        ss = ("три");
                        break;
                    case 4:
                        ss = ("четыре");
                        break;
                    case 5:
                        ss = ("пять");
                        break;
                    case 6:
                        ss = ("шесть");
                        break;
                    case 7:
                        ss = ("семь");
                        break;
                    case 8:
                        ss = ("восемь");
                        break;
                    case 9:
                        ss = ("девять");
                        break;
                }
                s += ss;
            }
            return s;
        }
    }
}
