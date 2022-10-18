using NUnit.Framework;
using TestProject1;

namespace TestProject1.tests
{
public class LoopsTests
    {
        [TestCase(2,2,4)]
        [TestCase(0,2,0)]
        [TestCase(2,0,1)]
        [TestCase(2,-2,0.25)]
        [TestCase(-2,2,4)]
        [TestCase(-2,3,-8)]
        public void FindAinPowerBTest (int a, int b, double expected)
        {
            double actual = Loops.FindAinPowerB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(49,6)]
        [TestCase(10,3)]
        [TestCase(1,0)]
        public void FindQuantityofNumbersSquareLessATest(int a, int expected)
        {
            int actual = Loops.FindQuantityofNumbersSquareLessA(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
