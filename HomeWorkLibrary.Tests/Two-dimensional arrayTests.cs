using NUnit.Framework;
using System;

namespace HomeWorkLibrary.Tests
{
    public class Two_dimensional_arrayTests
    {
        public static int[,] GetMock(int number)
        {
            int[,] array = new int[0, 0];
            switch (number)
            {
                case 1:
                    array = new int[,]
                    {
                        {5,6,7,8,9},
                        {10,11,12,13,14},
                        {-5,-6,-7,-8,-9}
                    };
                    break;
                case 2:
                    array = new int[,]
                    {
                        {5,6,7,8,9},
                        {10,11,12,13,14},
                        {0,1,2,3,4}
                    };
                    break;
                case 3:
                    array = new int[,]
                    {
                        {0,-1,-2,-3,-4},
                        {-10,-11,-12,-13,-14},
                        {-5,-6,-7,-8,-9}
                    };
                    break;
                case 4:
                    array = new int[,]
                    {
                        {5,10,-5},
                        {6,11,-6},
                        {7,12,-7},
                        {8,13,-8},
                        {9,14,-9}
                    };
                    break;
                case 5:
                    array = new int[,]
                    {
                        {5,10,0},
                        {6,11,1},
                        {7,12,2},
                        {8,13,3},
                        {9,14,4}
                    };
                    break;
                case 6:
                    array = new int[,]
                    {
                        {0,-10,-5},
                        {-1,-11,-6},
                        {-2,-12,-7},
                        {-3,-13,-8},
                        {-4,-14,-9}
                    };
                    break;
                case 7:
                    array = new int[,]{};
                    break;
            }
            return array;
        }

        [TestCase(1, -9)]
        [TestCase(2, 0)]
        [TestCase(3, -14)]
        public void SearchMinTests(int a, int expected)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);


            int actual = Two_dimensional_array.SearchMin(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 14)]
        [TestCase(2, 14)]
        [TestCase(3, 0)]
        public void SearchMaxTests(int a, int expected)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);


            int actual = Two_dimensional_array.SearchMax(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "2 4")]
        [TestCase(2, "2 0")]
        [TestCase(3, "1 4")]
        public void SearchIndexOfMinTests(int a, string expected)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);


            string actual = Two_dimensional_array.SearchIndexOfMin(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, "1 4")]
        [TestCase(2, "1 4")]
        [TestCase(3, "0 0")]
        public void SearchIndexOfMaxTests(int a, string expected)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);


            string actual = Two_dimensional_array.SearchIndexOfMax(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        public void CountNumberOfElementsGreaterAllNeighborsTests(int a, int expected)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);


            int actual = Two_dimensional_array.CountNumberOfElementsGreaterAllNeighbors(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 5)]
        [TestCase(3, 6)]
        public void transposeTests(int a, int b)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);
            int[,] expected = Two_dimensional_arrayTests.GetMock(b);


            int[,] actual = Two_dimensional_array.transpose(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7)]
        public void SearchMinException(int a)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);
            Assert.Throws<IndexOutOfRangeException>(() => Two_dimensional_array.SearchMin(array));
        }

        [TestCase(7)]
        public void SearchMaxException(int a)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);
            Assert.Throws<IndexOutOfRangeException>(() => Two_dimensional_array.SearchMax(array));
        }

        [TestCase(7)]
        public void SearchIndexOfMinException(int a)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);
            Assert.Throws<IndexOutOfRangeException>(() => Two_dimensional_array.SearchIndexOfMin(array));
        }

        [TestCase(7)]
        public void SearchIndexOfMaxException(int a)
        {
            int[,] array = Two_dimensional_arrayTests.GetMock(a);
            Assert.Throws<IndexOutOfRangeException>(() => Two_dimensional_array.SearchIndexOfMax(array));
        }
    }
}
