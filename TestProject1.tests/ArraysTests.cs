using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.tests
{
    public class ArraysTests
    {
        [TestCase(new int[] {1, 15, -8, 0, 23},-8)]
        [TestCase(new int[] {1, 1, 1, 1, 1},1)]
        public void FindMinValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,7,987,-567,0},987)]
        [TestCase(new int[] {0,0,0,0,0},0)]
        public void FindMaxValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,34,98,-5,-983,0},5)]
        [TestCase(new int[] {1,1,1,1,1,1},0)]
        public void FindIndexofMinValue(int[] array, int expected)
        {
            int actual=Arrays.FindIndexofMinValue(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {905,65,-999,0,1},0)]
        [TestCase(new int[] {0,0,0,0,0},0)]
        public void FindIndexofMaxValue(int[] array, int expected)
        {
            int actual=Arrays.FindIndexofMaxValue(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
