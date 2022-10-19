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
        [TestCase(0,0)]
        public void FindQuantityofNumbersSquareLessATest(int a, int expected)
        {
            int actual = Loops.FindQuantityofNumbersSquareLessA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-1)]
        public void FindQuantityofNumbersSquareLessATest_WhenAlessthanOne_ShouldThrowArgumentExcpetion(int a)
        {
            Assert.Throws<ArgumentException>(() => Loops.FindQuantityofNumbersSquareLessA(a));
        }
        [TestCase(18,9)]
        [TestCase(17,1)]
        [TestCase(0,0)]
        public void FindMaxDelitelATest(int a, int expected)
        {
            int actual=Loops.FindMaxDelitelA(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(0)]
        public void FindMaxDelitelATest_WhenAisLessTwo_ThenShouldThrowArgumentException(int a)
        {
            Assert.Throws<ArgumentException>(() => Loops.FindMaxDelitelA(a));
        }

        [TestCase(5,20,21)]
        [TestCase(20,5,21)]
        [TestCase(0,5,0)]
        [TestCase(-8,5,-7)]
        public void FindSumofNumbersDividedtoSevenTest(int a, int b, int expected)
        {
            int actual=Loops.FindSumofNumbersDividedtoSeven(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2)]
        [TestCase(0,0)]
        [TestCase(-7,-7)]
        public void FindSumofNumbersDividedtoSevenTest_WhenAandBareEqual_ShouldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Loops.FindSumofNumbersDividedtoSeven(a, b));
        }

        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(7,13)]
        public void FindNthNumberFibonacciTest(int N, int expected)
        {
            int acutal=Loops.FindNthNumberFibonacci(N);
            Assert.AreEqual(expected, acutal);
        }
    }
}
