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

        [TestCase(new int[] {5,9,1,0,0,15}, 24)]
        [TestCase(new int[] {5,-9,1,0,0,15}, 6)]
        public void FindSumOfNumbersWithEvenIndexTest(int[] array, int expected)
        {
            int actual=Arrays.FindSumOfNumbersWithEvenIndex(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {1,2,3,4,5,6},new int[] {6,5,4,3,2,1})]
        [TestCase(new int[] {1,2,3,4,5,6,7},new int[] {7,6,5,4,3,2,1})]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            int[] actual=Arrays.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] {56,0,2,5,7,4,6},12)]
        public void FindSumOfEvenNumbersInArrayTest(int[] array, int expected)
        {
            int actual=Arrays.FindSumOfEvenNumbersInArray(array);
            Assert.AreEqual(expected, actual);
        }
    }
}
