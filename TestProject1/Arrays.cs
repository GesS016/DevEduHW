using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
public static class Arrays
    {
        public static int FindMinValue(int[] array)
        {
            if (array.Length==0)
            {
                throw new ArgumentException("array is empty");
            }
            int min = array[0];
            for(int i=1;i<array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int FindMaxValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int FindIndexofMinValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int min = array[0];
            int indexOfMin=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    indexOfMin = i;
                }
            }
            return indexOfMin;
        }

        public static int FindIndexofMaxValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int max = array[0];
            int indexOfMax=0;
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    indexOfMax = i;

                }
            }
            return indexOfMax;
        }

        public static int FindSumOfNumbersWithEvenIndex(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int sum = 0;
            for(int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }
            return sum;
        }

        public static int[] ReverseArray(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int temp;
            int lastIndex=array.Length-1;
                for (int i = 0; i < array.Length/ 2; i++)
                {
                    temp = array[i];
                    array[i] = array[lastIndex];
                    array[lastIndex] = temp;
                    lastIndex --;
                }
            return array;

        }

        public static int FindSumOfEvenNumbersInArray(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int sum=0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]%2!=0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int[] ReverseTwoHalfsOfArray(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty");
            }
            int temp;
            int firstIndexOfHalf;
            if(array.Length%2!=0)
            {
                firstIndexOfHalf=array.Length/2+1;
            }
            else
            {
                firstIndexOfHalf = array.Length / 2;
            }
            for(int i = 0; i < array.Length/2; i++)
            {
                temp = array[i];
                array[i]=array[firstIndexOfHalf];
                array[firstIndexOfHalf] =temp;
                firstIndexOfHalf++;
            }
            return array;
        }

        public static int[] SortWithSelectIncrease(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int IndexOfMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[IndexOfMin])
                    {
                        IndexOfMin = j;
                    }
                }
                int tmp = array[IndexOfMin];
                array[IndexOfMin] = array[i];
                array[i] = tmp;
            }
            return array;
        }
    }
}
