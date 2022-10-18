using System.Runtime.CompilerServices;
using TestProject1;
using NUnit.Framework;

namespace TestProject1.tests
{
    public class VariablesTests
    {
        [TestCase(2,3,19)]
        [TestCase(4,3,-29)]
        public void SolveExampleTest(int a, int b, int expected)
        {
            int actual = Variables.SolveExample(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,2)]
        public void SolveExampleTest_WhenAisEqualB_ThenShouldThrowArgumentException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveExample(a, b));
        }

        [TestCase(1,2,3,1)]
        [TestCase(-1,2,3,-1)]
        [TestCase(-1,3,2,1)]
        [TestCase(1,3,2,-1)]
        public void SolveEquationTest(int a, int b, int c, int expected)
        {
            int actual=Variables.SolveEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,1,2)]
        public void SolveEquationTest_WhenAisEqualZero_ThenShouldThrowArgumentException(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => Variables.SolveEquation(a,b,c));
        }
        
        [TestCase(1, 1, 2, 2, "y=1x+0")]
        public void FindStraightLineEquationTest(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Variables.FindStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,2,1,2)]
        public void FindStraightLineEquationTest_WhenSameDot_ThenShouldThrowArgumentException(int x1, int y1, int x2, int y2)
        {
            Assert.Throws<ArgumentException>(()=> Variables.FindStraightLineEquation(x1, y1, x2, y2));
        }
    }
}