using NUnit.Framework;
using System;

namespace HomeWorkLibrary.Tests
{
    public class ConditionsTests
    {
        [TestCase(7, 4, 11)]
        [TestCase(5, 5, 25)]
        [TestCase(4, 9, -5)]
        public void СompareAndSolveTests(double a, double b, double expected)
        {
            double actual = conditions.СompareAndSolve(a, b);
            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestCase(7, 4, "I четверть")]
        [TestCase(-5, 5, "II четверть")]
        [TestCase(-4, -9, "III четверть")]
        public void FindingAQuarterTests(double a, double b, string expected)
        {
            string actual = conditions.FindingAQuarter(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 4, 1, "1 4 7")]
        [TestCase(3, 8, 99, "3 8 99")]
        [TestCase(8, 12, 10, "8 10 12")]
        public void FindingOfMaxTests(double a, double b, double c, string expected)
        {
            string actual = conditions.FindingOfMax(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(15, 6, 9, new double[0])]
        [TestCase(4, 5, 1, new double[] {-0.25,-1 })]
        [TestCase(1, -6, 9, new double[] {3})]
        public void SolutionOfAquadraticEquationTests(double a, double b, double c, double[] expected)
        {
            double[] actual = conditions.SolutionOfAquadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, "Двенадцать")]
        [TestCase(50, "Пятьдесят ")]
        [TestCase(99, "Девяносто девять")]
        public void TranslateIntoLettersintTests(int a, string expected)
        {
            string actual = conditions.TranslateIntoLettersint(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void FindingAQuarterException(int a,int b)
        {
            Assert.Throws<ArgumentException>(() => conditions.FindingAQuarter(a,b));
        }

        [TestCase(0, 0, 0)]
        public void SolutionOfAquadraticEquationException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => conditions.SolutionOfAquadraticEquation(a,b,c));
        }

        [TestCase(1)]
        [TestCase(151)]
        public void TranslateIntoLettersintException(int a)
        {
            Assert.Throws<ArgumentException>(() => conditions.TranslateIntoLettersint(a));
        }
    }
}