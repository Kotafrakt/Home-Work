using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class Cycle
    {
        public static double DoInvolution(int a,int b)
        {
            double c = 1;
            if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    c *= a;
                }
                return c;
            }
            else if (b == 0)
            {
                return c;
            }
            else
            {
                for (int i = 0; i > b; i--)
                {
                    c *= a;
                }
                c = 1 / c;
                return c;
            }
        }
        public static int[] FindingTheDivisor(int a)
        {
            if (a<0)
            {
                throw new Exception("a<0");
            }
            int x = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % a) == 0)
                {
                    x++;
                }
            }
            int[] array = new int[x];
            int y = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % a) == 0)
                {
                    array[y] = i;
                    y++;
                }
            }
            return array;
        }
        public static int FindingTheRootDivisor(int a)
        {
            int j = 0;
            for (int i = 1; (i * i) < a; i++)
            {
                j++;
            }
            return j;
        }
        public static int FindingTheMaxDivisor(int a)
        {
            int c = 0;
            a = Math.Abs(a);
            for (int i = 1; i < a; i++)
            {
                if ((a % i) == 0)
                {
                    c = i;
                }
            }
            if (c==0)
            {
                throw new Exception("на ноль делить нельзя");
            }
            return c;
        }

        public static int FindingDivisorSevenSum(int a,int b)
        {
            int c = 0;
            if (a > b)
            {
                for (int i = b; i < a; i++)
                {
                    if ((i % 7) == 0)
                    {
                        c += i;
                    }
                }
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    if ((i % 7) == 0)
                    {
                        c += i;
                    }
                }
            }
            return c;
        }
        public static int FindingNthNumberOfTheFibonacciSeries(int a)
        {
            if (a<0)
            {
                throw new Exception("a<0");
            }
            int b = 0;
            int c = 1;
            int d = 1;
            for (int i = 2; i <= a; i++)
            {
                d = b + c;
                b = c;
                c = d;
            }
            return d;
        }
        public static int FindingNthNumberOfTheFibonacciSeries2(int a,int b)
        {
            while (a != b)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static double SearchBinaryMethod(double a,double d=0.1)
        {
            double l = 0;
            double r = a;
            double m = r;
            while (!((m + d) * (m + d) * (m + d) >= a && (m - d) * (m - d) * (m - d) <= a))
            {
                if (m * m * m > a)
                {
                    r = m;
                }
                else
                {
                    l = m;
                }
                m = (l + r) / 2;
            }
            return m;
        }
        public static int SearchForOddNumber(int a)
        {
            int b = 0;
            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    b++;
                    a /= 10;
                }
                else
                {
                    a /= 10;
                }
            }
            return b;
        }
        public static int SearchNumber(int a)
        {
            int b = 1;
            int tmpa = a;
            while (tmpa != 0)
            {
                b *= 10;
                tmpa /= 10;
            }
            int c = 0;
            while (a != 0)
            {
                b /= 10;
                c = (a % 10) * b + c;
                a /= 10;
            }
            return c;
        }
        public static string SearchForSumsOfEvenNumbers(int a)
        {
            if (a<0)
            {
                throw new Exception("a<0");
            }
            int i = 1;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            string s="";
            while (i <= a)
            {
                d = i;
                while (d != 0)
                {
                    e = d % 10;
                    if ((e % 2) == 0)
                    {
                        b += e;
                    }
                    else
                    {
                        c += e;
                    }
                    d /= 10;
                }
                if (b > c)
                {
                    s += i + " ";
                }
                b = 0;
                c = 0;
                i++;
            }
            return s;
        }
        public static bool SearchForIdenticalNumbers(int a, int b)
        {
            int c;
            int d;
            int e = 0;
            bool mirror;
            while (a != 0)
            {
                c = a % 10;
                int tmpb = b;
                while (tmpb != 0)
                {
                    d = tmpb % 10;
                    if (c == d)
                    {
                        e++;
                        break;
                    }
                    tmpb /= 10;
                }
                a /= 10;
            }
            if (e > 0)
            {
                mirror = true;

            }
            else
            {
                mirror = false;
            }
            return mirror;
        }
    }
}
