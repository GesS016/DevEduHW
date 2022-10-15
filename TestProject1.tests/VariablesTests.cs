using System.Runtime.CompilerServices;
using TestProject1;
using NUnit.Framework;

namespace TestProject1.tests
{
    public class VariablesTests
    {
        [TestCase(2,3,19)]
        [TestCase(4,4,0)]
        public void SolveExampleTest(int a, int b, int expected)
        {
            int actual = Variables.SolveExample(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,3,1)]
        [TestCase(0,2,3,555)]
        [TestCase(-1,2,3,-1)]
        [TestCase(-1,3,2,1)]
        [TestCase(1,3,2,-1)]
        public void SolveEquationTest(int a, int b, int c, int expected)
        {
            int actual=Variables.SolveEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2, 2, "y=5x+10")]
        public void FindStraightLineEquationTest(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Variables.FindStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
    }
}