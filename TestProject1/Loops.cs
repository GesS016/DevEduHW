using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public static class Loops
    {
        public static double FindAinPowerB(int a, int b)
        {
            double result = a;
            if (b > 0)
            {
                while (b != 1)
                {
                    result = result * a;
                    b = b - 1;
                }
                return result;
            }
            else if (b == 0)
            {
                result = 1;
                return result;
            }
            else
            {
                while (b != -1)
                {
                    result = result * a;
                    b = b + 1;
                }
                result = 1 / result;
                return result;
            }
        }

        public static int FindQuantityofNumbersSquareLessA(int a)
        {
            double b=Math.Sqrt(a);
            int c = 1;
            int result = 0;
            while(c<b)
            {
                result++;
            }
            return result;
        }
    }
}
