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

        public static int[] SortingwithBubbleIncrease(int[] array)
        {
            int i = 0;
            int min=array[i];
            int max=array[i+1];
            while(i<=array.Length)
            {
                if(min<=max)
                {
                    i++;
                }
                else if(min>max)
                {
                    int temp = min;
                    min = max;
                    max = temp;
                    i++;
                }
            }
            return array;
        }
    }
}
