using System;
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
            int quantity = 1;
            int result = 0;
            while(quantity<b)
            {
                result++;
                quantity++;
            }
            return result;
        }

        public static int FindMaxDivisorA(int a) //4
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
            int firstOfThree = 1;
            int secondOfThree = 1;
            int thirdOfThree;
            int result;
            if(N==1 || N==2)
            {
                result = 1;
            }
            else
            {
                for (int i = 3; i <= N; i++)
                {
                    thirdOfThree = firstOfThree + secondOfThree;
                    firstOfThree = secondOfThree;
                    secondOfThree = thirdOfThree;
                }
                result = secondOfThree;
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
        public static int FindMirrorNumber(int number)
        {
            int result = 0;
            while (number % 10 != 0 || number / 10 != 0)
            {
                int digit = number % 10;
                result = result * 10 + digit;
                number = number / 10;
            }
            return result;
        }

        public static bool FindifThereAreSameNumbers(int firstNumber, int secondNumber)
        {
            int temp = secondNumber;
            if(firstNumber == secondNumber)
            {
                return true;
            }
            if (firstNumber==0)
            {
                while (secondNumber != 0)
                {
                    int digitOfSecondNumber = secondNumber % 10;
                    secondNumber /= 10;
                    if (firstNumber == digitOfSecondNumber)
                    {
                        return true;
                    }
                }
            }
            if(secondNumber==0)
            {
                while (firstNumber != 0)
                {
                    int digitOfFirstNumber = firstNumber % 10;
                    firstNumber /= 10;
                    if (secondNumber == digitOfFirstNumber)
                    {
                        return true;
                    }
                }
            }
            while(firstNumber!=0)
                {
                    int digitOfFirstNumber = firstNumber % 10;
                    firstNumber /= 10;
                    secondNumber = temp;
                    while (secondNumber!=0)
                    {
                        int digitOfSecondNumber = secondNumber % 10;
                        secondNumber /= 10;
                        if (digitOfFirstNumber == digitOfSecondNumber)
                        {
                            return true;
                        }
                    }
                }
            return false;
        }

        public static int[] FindNumbersDividedToA(int divider)
        {
            int i = 0;
            int n= 1000 / divider;
            int[] array =new int[n];
            int number=1;
            while(number<=1000)
            {
                if(number%divider==0)
                {
                    array[i] = number;
                    i++;
                }
                number++;
            }
            return array;
        }
    }
}
