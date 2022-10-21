﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public static class Loops
    {
        public static double FindAinPowerB(int a, int b) //1
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

        public static int FindQuantityofNumbersSquareLessA(int a) //3
        {
            if (a < 0)
            {
                throw new ArgumentException("a<0");
            }
            double b=Math.Sqrt(a);
            int c = 1;
            int result = 0;
            while(c<b)
            {
                result++;
                c++;
            }
            return result;
        }

        public static int FindMaxDelitelA(int a) //4
        {
            if(a<=1)
            {
                throw new ArgumentException("a<=1");
            }
            int b = 2;
            while(a%b!=0)
            {
                b++;
            }
            int result = a / b;
            return result;
        }

        public static int FindSumofNumbersDividedtoSeven(int a, int b)
        {
            if(a==b)
            {
                throw new ArgumentException("a=b");
            }
            int result = 0;
            if (a>b)
            {
                for(int i = b; i <= a; i++)
                {
                    if(i%7==0)
                    {
                        result = result + i;
                    }
                }
            }
            if(b>a)
            {
                for (int i = a ;i <= b; i++)
                {
                    if(i%7==0)
                    {
                        result = result + i;
                    }
                }
            }
            return result;
        }

        public static int FindNthNumberFibonacci(int N)
        {
            int a = 1;
            int b = 1;
            int c;
            int result;
            if(N==1 || N==2)
            {
                result = 1;
            }
            else
            {
                for (int i = 3; i <= N; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                result = b;
            }
            return result;
        }

        public static int FindGreatestCommonDivisorEuclid(int firstNumber,int secondNumber)
        {
            int result=0;
            int remainder;
            if(firstNumber==0 || secondNumber==0)
            {
                throw new ArgumentException("Divide to zero exception");
            }
            if (firstNumber >= secondNumber)
            {
                if (firstNumber % secondNumber == 0)
                {
                    result= secondNumber;
                }
                else
                {
                    while (firstNumber % secondNumber != 0)
                    {
                        remainder = secondNumber;
                        secondNumber = firstNumber % secondNumber;
                        firstNumber = remainder;
                    }
                    result= secondNumber;
                }
            }
            if (secondNumber > firstNumber)
            {
                if (secondNumber % firstNumber == 0)
                {
                    result= firstNumber;
                }
                else
                {
                    while (secondNumber % firstNumber != 0)
                    {
                        remainder = firstNumber;
                        firstNumber = secondNumber % firstNumber;
                        secondNumber = remainder;
                    }
                    result= firstNumber;
                }
            }
            return result;
        }

        public static int FindEvenDigits(int number)
        {
            int evenDigit = 0;
            while (number % 10 != 0 || number / 10 != 0)
            {
                int digit = number % 10;
                number = number / 10;
                if (digit % 2 != 0)
                {
                    evenDigit++;
                }
            }
            return evenDigit;
        }
    }
}
