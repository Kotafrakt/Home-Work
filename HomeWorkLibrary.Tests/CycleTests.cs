using NUnit.Framework;

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
    }
}
