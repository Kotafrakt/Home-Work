using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class circs
    {
        public static double hw21(double a, double b)
        {
            //Console.WriteLine("Введите а");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ввелите b");
            //double b = Convert.ToDouble(Console.ReadLine());
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
        public static string hw22(double x, double y)
        {
            //Console.WriteLine("Введите X");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Ввелите Y");
            //double y = Convert.ToDouble(Console.ReadLine());
            string s;
            if (x > 0)
            {
                if (y > 0)
                {
                    s="I четверть";
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
        //public static double hw23(double a, double b, double c)
        //{
        //    Console.WriteLine("Введите а");
        //    double a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Ввелите b");
        //    double b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Ввелите c");
        //    double c = Convert.ToDouble(Console.ReadLine());
        //    if (a > b
        //        && a > c)
        //    {
        //        Console.WriteLine(a);
        //        if (b > c)
        //        {
        //            Console.WriteLine(b);
        //            Console.WriteLine(c);
        //        }
        //        else
        //        {
        //            Console.WriteLine(c);
        //            Console.WriteLine(b);
        //        }
        //    }
        //    else if (b > c)
        //    {
        //        Console.WriteLine(b);
        //        if (a > c)
        //        {
        //            Console.WriteLine(a);
        //            Console.WriteLine(c);
        //        }
        //        else
        //        {
        //            Console.WriteLine(c);
        //            Console.WriteLine(a);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(c);
        //        if (a > b)
        //        {
        //            Console.WriteLine(a);
        //            Console.WriteLine(b);
        //        }
        //        else
        //        {
        //            Console.WriteLine(b);
        //            Console.WriteLine(a);
        //        }
        //    }
        //}

    }
}
