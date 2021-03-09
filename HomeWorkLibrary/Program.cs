using System;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 324;
            int l = 0;
            int r = 1000;
            int m = (l + r) / 2;
            while (m != a)
            {
                if (m > a)
                {
                    r = m;
                }
                else
                {
                    l = m;
                }
                m = (l + r) / 2;
            }
            Console.WriteLine(m);
        }
    }
}
