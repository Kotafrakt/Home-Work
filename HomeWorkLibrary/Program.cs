using System;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Array.create(10);
            Array.Print(a);
            int[] b =Array.Reverse(a);
            Array.Print(b);
        }
    }
}