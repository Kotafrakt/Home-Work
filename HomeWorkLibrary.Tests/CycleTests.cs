using NUnit.Framework;
using System;

namespace HomeWorkLibrary.Tests
{
    public class CycleTests
    {
        [TestCase(3, 2, 9)]
        [TestCase(-2, 10, 1024)]
        [TestCase(5, -3, 0.008)]
        public void DoInvolutionTests(int a, int b, double expected)
        {
            double actual = Cycle.DoInvolution(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5000, new int[0])]
        [TestCase(999, new int[] {999})]
        [TestCase(300, new int[] { 300, 600, 900 })]
        public void FindingTheDivisorTests(int a, int[] expected)
        {
            int[] actual = Cycle.FindingTheDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(0, 0)]
        [TestCase(-26, 0)]
        public void FindingTheRootDivisorTests(int a, int expected)
        {
            int actual = Cycle.FindingTheRootDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(121, 11)]
        [TestCase(99, 33)]
        [TestCase(10,5)]
        public void FindingTheMaxDivisorTests(int a, int expected)
        {
            int actual = Cycle.FindingTheMaxDivisor(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 22, 21)]
        [TestCase(-10, 33,63)]
        [TestCase(10, 5, 7)]
        public void FindingDivisorSevenSumTests(int a, int b, int expected)
        {
            int actual = Cycle.FindingDivisorSevenSum(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        public void FindingNthNumberOfTheFibonacciSeriesTests(int a, int expected)
        {
            int actual = Cycle.FindingNthNumberOfTheFibonacciSeries(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 7, 1)]
        [TestCase(22, 121, 11)]
        [TestCase(-9, 99, 9)]
        public void SearchForDivisorByEuclideanMethodTests(int a, int b, int expected)
        {
            int actual = Cycle.SearchForDivisorByEuclideanMethod(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(99, 4.626)]
        [TestCase(-27, -3)]
        [TestCase(125, 5)]
        public void SearchBinaryMethodTests(double a, double expected)
        {
            double actual = Cycle.SearchBinaryMethod(a);
            Assert.AreEqual(expected, actual,0.1);
        }

        [TestCase(2, 0)]
        [TestCase(99, 2)]
        [TestCase(-12345, 3)]
        public void SearchForOddNumberTests(int a, int expected)
        {
            double actual = Cycle.SearchForOddNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(95687, 78659)]
        [TestCase(-12345, -54321)]
        public void SearchNumberTests(int a, int expected)
        {
            double actual = Cycle.SearchNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "")]
        [TestCase(10, "2 4 6 8 ")]
        [TestCase(20, "2 4 6 8 12 14 16 18 20 ")]
        public void SearchForSumsOfEvenNumbersTests(int a, string expected)
        {
            string actual = Cycle.SearchForSumsOfEvenNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 21, true)]
        [TestCase(12345, 6789, false)]
        [TestCase(-36578, 12345, true)]
        public void SearchForIdenticalNumbersTests(int a, int b, bool expected)
        {
            bool actual = Cycle.SearchForIdenticalNumbers(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        public void FindingTheDivisorException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycle.FindingTheDivisor(a));
        }

        [TestCase(-5)]
        public void FindingNthNumberOfTheFibonacciSeriesException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycle.FindingNthNumberOfTheFibonacciSeries(a));
        }

        [TestCase(1, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 0)]
        public void SearchForDivisorByEuclideanMethodException(int a,int b)
        {
            Assert.Throws<ArgumentException>(() => Cycle.SearchForDivisorByEuclideanMethod(a,b));
        }

        [TestCase(-1)]
        public void SearchForSumsOfEvenNumbersException(int a)
        {
            Assert.Throws<ArgumentException>(() => Cycle.SearchForSumsOfEvenNumbers(a));
        }
    }
}

