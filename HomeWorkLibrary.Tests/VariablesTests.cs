using NUnit.Framework;
using System;

namespace HomeWorkLibrary.Tests
{
    public class VariablesTests
    {
        [TestCase(5, 10, 25)]
        [TestCase(3, 7, 16)]
        [TestCase(2.5, 5.6, 14.14)]
        public void SolveTheEquationTests(double a, double b, double expected)
        {
            double actual = Variables.SolveTheEquation(a, b);
            Assert.AreEqual(expected, actual, 0.1);
        }
        [TestCase(5, 10, ("10 5"))]
        [TestCase(3, 7, ("7 3"))]
        [TestCase(256, 999, ("999 256"))]
        public void ChangePlacesTests(double a, double b, string expected)
        {
            string actual = Variables.ChangePlaces(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 2, new double[] { 5, 0 })]
        [TestCase(9, 2, new double[] { 4, 1 })]
        [TestCase(51, 2, new double[] { 25, 1 })]
        public void DivisionAndRemainderTests(int a, int b, double[] expected)
        {
            double[] actual = Variables.DivisionAndRemainder(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4, 10, 6)]
        [TestCase(2.5, 7, 99, 36.8)]
        [TestCase(4.3, 2.99, -52, -12.7884)]
        public void SolveLinearEquationTests(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestCase(5, 15, 10, 9, ("y=-0,1x+10,5"))]
        [TestCase(-2.5, -10, 3, 0.6, ("y=0,32x+3,8"))]
        [TestCase(0, 0, 6, 0, ("x=0"))]
        public void FindingStraightTests(double a, double b, double c, double d, string expected)
        {
            string actual = Variables.FindingStraight(a, b, c, d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1)]
        [TestCase(5, 5)]
        [TestCase(3, 3)]
        public void SolveTheEquationException(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveTheEquation(a,b));
        }

        [TestCase(1, 0)]
        public void DivisionAndRemainderException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Variables.DivisionAndRemainder(a, b));
        }

        [TestCase(0, 5, 10)]
        public void SolveLinearEquationException(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => Variables.SolveLinearEquation(a, b, c));
        }

        [TestCase(0, 5, 5)]
        public void SolveLinearEquationException_0(double a, double b, double c)
        {
            Assert.Throws<ArgumentNullException>(() => Variables.SolveLinearEquation(a, b, c));
        }
    }
}