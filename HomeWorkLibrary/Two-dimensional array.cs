using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class Two_dimensional_array
    {
        public static int[,] create(int a, int b)
        {
            if (a < 0||b<0)
            {
                throw new Exception("длинна массива не может быть отрицательной");
            }
            int[,] array = new int[a, b];
            Random random = new Random();
            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1);j++)
                {
                    array[i,j]=random.Next(9);
                }
            }
            return array;
        }
        public static void print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j=0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public static int SearchMin(int[,] array)
        {
            if (array.Length < 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int tmp = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (tmp>array[i,j])
                    {
                        tmp = array[i, j];
                    }
                }
            }
            return tmp;
        }
        public static int SearchMax(int[,] array)
        {
            if (array.Length < 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int tmp = array[0, 0];
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0; j<array.GetLength(1);j++)
                {
                    if (tmp<array[i,j])
                    {
                        tmp = array[i, j];
                    }    
                }
            }
            return tmp;
        }
        public static string SearchIndexOfMin(int[,] array)
        {
            if (array.Length < 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int tmp = array[0, 0];
            string tmpI="0 0";
            {
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for(int j=0;j<array.GetLength(1);j++)
                    {
                        if (tmp>array[i,j])
                        {
                            tmp = array[i, j];
                            tmpI = ($"{i} {j}");
                        }
                    }
                }
            }
            return tmpI;
        }
        public static string SearchIndexOfMax(int[,] array)
        {
            if (array.Length < 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int tmp = array[0, 0];
            string tmpI = "0 0";
            {
                for (int i=0;i<array.GetLength(0);i++)
                {
                    for (int j=0;j<array.GetLength(1);j++)
                    {
                        if (tmp < array[i,j])
                        {
                            tmp = array[i, j];
                            tmpI = ($"{i} {j}");
                        }
                    }
                }
            }
            return tmpI;
        }
        public static int CountNumberOfElementsGreaterAllNeighbors(int[,] array)
        {
            int SumI = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int a = i - 1;
                    int b = j + 1;
                    int c = i + 1;
                    int d = j - 1;

                    if ((a < 0 || array[i, j] > array[i - 1, j])
                        && (b >= array.GetLength(1) || array[i, j] > array[i, j + 1])
                        && (c >= array.GetLength(0) || array[i, j] > array[i + 1, j])
                        && (d < 0 || array[i, j] > array[i, j - 1]))
                    {
                        SumI++;
                    }
                }
            }
            return SumI;
        }
        public static int[,] transpose(int[,] array)
        {
            int a = array.GetLength(1);
            int b = array.GetLength(0);
            int[,] tmparray = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    tmparray[i, j] = array[j, i];
                }    
            }
            return tmparray;
        }
    }
}
