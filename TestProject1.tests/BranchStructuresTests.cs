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
    }
}
