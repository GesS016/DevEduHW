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
            int min = array[0];
            int i;
            for (i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return i;
        }

        public static int FindIndexofMaxValue(int[] array)
        {
            int max = array[0];
            int i;
            for (i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return i;
        }
    }
}
