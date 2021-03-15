using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkLibrary
{
    public static class Array
    {
        public static int[] create(int a)
        {
            if (a < 0)
            {
                throw new Exception("длинна массива не может быть отрицательной");
            }
            int[] array = new int[a];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-100,101);
            }
            return array;
        }
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static int SearchMin(int[] array)
        {
            if (array.Length<=0)
            {
                throw new ArgumentException("пустой массив");
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static int SearchMax(int[] array)
        {
            if (array.Length <= 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int SearchMinIndex(int[] array)
        {
            if (array.Length <= 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int min = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static int SearchMaxIndex(int[] array)
        {
            if (array.Length <= 0)
            {
                throw new ArgumentException("пустой массив");
            }
            int max = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static int SearchSumOddindex (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 2) != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int[] Reverse(int[] array)
        {
            int b;
            for (int i = 0; i < (array.Length / 2); i++)
            {
                b = array[i];
                int x = array.Length - i - 1;
                array[i] = array[x];
                array[x] = b;
            }
            return array;
        }
        public static int SearhOddNumbers(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        public static int[] ReverseOfHalfArray(int[] array)
        {
            int y;
            int b = array.Length / 2;
            int x;
            for (int i = 0; i < b; i++)
            {
                y = array[i];
                x = (array.Length - 1) / 2 + 1 + i;
                array[i] = array[x];
                array[x] = y;
            }
            return array;
        }
        public static int[] SortingOfIncrease(int[] array)
        {
            int y;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        y = array[i];
                        array[i] = array[j];
                        array[j] = y;
                    }
                }
            }
            return array;
        }
        public static int[] SortingOfDecrease(int[] array)
        {
            int y;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)

                {
                    if (array[j - 1] < array[j])
                    {
                        y = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = y;
                    }
                }
            }
            return array;
        }

    }
}
