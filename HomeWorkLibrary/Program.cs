using System;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables.DivisionAndRemainder(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            int q = Variables.DivisionAndRemainder(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(q);
        }
    }
}
