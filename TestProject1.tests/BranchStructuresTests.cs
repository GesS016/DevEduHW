using TestProject1;
using NUnit.Framework;

namespace TestProject1.tests
{
    public class BranchStructuresTests
    {
        [TestCase(3,1,4)]
        [TestCase(3,0,3)]
        [TestCase(3,3,9)]
        [TestCase(1,3,-2)]
        public void SolveAgreaterlessBTest(int a, int b, int expected)
        {
            int actual = BranchStructures.SolveAgreaterlessB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,2,"on Y axis")]
        [TestCase(2,0,"on X axis")]
        [TestCase(2,2,"I")]
        [TestCase(-2,2,"II")]
        [TestCase(0,0,"on Zero")]
        [TestCase(2,-2,"IV")]
        [TestCase(-2,-2,"III")]
        public void FindQuarterPlaceofDotTest(int x, int y, string expected)
        {
            string actual = BranchStructures.FindQuarterPlaceofDot(x, y);
            Assert.AreEqual(expected, actual); 
        }

        [TestCase(25,"двадцать пять")]
        [TestCase(30,"тридцать")]
        [TestCase(16,"шестнадцать")]
        public void WriteDigitinStringTest(int a, string expected)
        {
            string actual = BranchStructures.WriteDigitinString(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3,"1,2,3")]
        [TestCase(1,3,2,"1,2,3")]
        [TestCase(3,1,2,"1,2,3")]
        [TestCase(3,2,1,"1,2,3")]
        [TestCase(2,1,3,"1,2,3")]
        [TestCase(2,3,1,"1,2,3")]
        public void WriteThreeNumbersIncreaseTest(int firstNumber, int secondNumber, int thirdNumber, string expected)
        {
            string actual=BranchStructures.WriteThreeNumbersIncrease(firstNumber, secondNumber, thirdNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,-2,-24,"x1=6,x2=-4")]
        public void SolveSqaureEquation(double a, double b, double c, string expected)
        {
            string actual = BranchStructures.SolveSqaureEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
