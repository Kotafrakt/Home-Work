using System;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Variables.FindingStraight(5, 15, 10, 9));
            //Console.WriteLine(Cycle.SearchBinaryMethod(27));
            //int[,]arr=Two_dimensional_array.create(5, 6);
            //Two_dimensional_array.print(arr);
            //Console.WriteLine(Two_dimensional_array.CountNumberOfElementsGreaterAllNeighbors(arr));
            int[,] array = new int[,]
                    {
                        {5, 6, 7, 8, 9},
                        {10,11,12,13,14},
                        {-5,-6,-7,-8,-9}
                    };
            Two_dimensional_array.print(array);
            int[,] b=Two_dimensional_array.transpose(array);
            Two_dimensional_array.print(b);
        }
    }
}