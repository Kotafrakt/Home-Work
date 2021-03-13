using NUnit.Framework;
using System;

namespace HomeWorkLibrary.Tests
{
    public class ArrayTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, 11)]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, -5)]
        public void SearchMinTests(int[] a, int expected)
        {
            int actual = Array.SearchMin(a);
            Assert.AreEqual(expected,actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, 55)]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, 98)]
        public void SearchMaxTests(int[] a, int expected)
        {
            int actual = Array.SearchMax(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, 2)]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, 4)]
        public void SearchMinIndexTests(int[] a, int expected)
        {
            int actual = Array.SearchMinIndex(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, 4)]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, 1)]
        public void SearchMaxIndexTests(int[] a, int expected)
        {
            int actual = Array.SearchMaxIndex(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, 77)]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, 104)]
        [TestCase(new int[] {}, 0)]
        public void SearchSumOddindexTests(int[] a, int expected)
        {
            int actual = Array.SearchSumOddindex(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 22, 33, 11, 44, 55 }, new int[] { 55, 44, 11, 33, 22 })]
        [TestCase(new int[] { 0, 98, 33, 6, -5 }, new int[] { -5, 6, 33, 98, 0 })]
        [TestCase(new int[] { }, new int[] { })]

        public void ReverseTests(int[] a, int[] expected)
        {
            int[] actual = Array.Reverse(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4)]
        [TestCase(new int[] { 22 }, 0)]
        [TestCase(new int[] { 0, 13,-15,6}, 2)]
        [TestCase(new int[] { }, 0)]

        public void SearhOddNumbersTests(int[] a, int expected)
        {
            int actual = Array.SearhOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[] { 22, 33, 11, 44, -55 }, new int[] { 44, -55, 11, 22, 33 })]
        [TestCase(new int[] { 0, 98,6, -5 }, new int[] { 6, -5, 0, 98 })]
        [TestCase(new int[] { }, new int[] { })]

        public void ReverseOfHalfArrayTests(int[] a, int[] expected)
        {
            int[] actual = Array.ReverseOfHalfArray(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 22, 33, 11, 44, -55 }, new int[] { -55, 11, 22, 33, 44 })]
        [TestCase(new int[] { 0, 13, -15, 6 }, new int[] { -15, 0, 6, 13 })]
        [TestCase(new int[] { 2, -48, 33, 101, -5 }, new int[] { -48, -5, 2, 33, 101 })]
        [TestCase(new int[] { }, new int[] { })]

        public void SortingOfIncreaseTests(int[] a, int[] expected)
        {
            int[] actual = Array.SortingOfIncrease(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 22, 33, 11, 44, -55 }, new int[] { 44, 33, 22, 11, -55 })]
        [TestCase(new int[] { 0, 13, -15, 6 }, new int[] { 13, 6, 0, -15 })]
        [TestCase(new int[] { 2, -48, 33, 101, -5 }, new int[] { 101, 33, 2, -5, -48 })]
        [TestCase(new int[] { }, new int[] { })]

        public void SortingOfDecreaseTests(int[] a, int[] expected)
        {
            int[] actual = Array.SortingOfDecrease(a);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(new int[] {})]
        public void SearchMinException(int[] a)
        {
            Assert.Throws<IndexOutOfRangeException>(()=>Array.SearchMin(a));
        }

        [TestCase(new int[] { })]
        public void SearchMaxException(int[] a)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Array.SearchMax(a));
        }

        [TestCase(new int[] { })]
        public void SearchMinIndexException(int[] a)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Array.SearchMinIndex(a));
        }

        [TestCase(new int[] { })]
        public void SearchMaxIndexException(int[] a)
        {
            Assert.Throws<IndexOutOfRangeException>(() => Array.SearchMaxIndex(a));
        }
    }
}
