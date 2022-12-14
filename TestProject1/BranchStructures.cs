namespace TestProject1
{
    public static class BranchStructures
    {
        public static int SolveAgreaterlessB(int a, int b) //1
        {
            int result;
            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }

        public static string FindQuarterPlaceofDot(int x, int y) //2
        {
            string result;
            if (x > 0 && y > 0)
            {
                result = "I";
            }
            else if (x < 0 && y > 0)
            {
                result = "II";
            }
            else if (x < 0 && y < 0)
            {
                result = "III";
            }
            else if (x > 0 && y < 0)
            {
                result = "IV";
            }
            else if (x == 0 && y != 0)
            {
                result = "on Y axis";
            }
            else if (y == 0 && x != 0)
            {
                result = "on X axis";
            }
            else
            {
                result = "on Zero";

            }
            return result;
        }

        public static string WriteDigitinString(int a) //5
        {
            string result = "";
            string decyatki = "";
            string edinici = "";
            if (a < 20)
            {
                switch (a)
                {
                    case 10:
                        result = "десять";
                        break;
                    case 11:
                        result = "одиннадцать";
                        break;
                    case 12:
                        result = "двенадцать";
                        break;
                    case 13:
                        result = "тринадцать";
                        break;
                    case 14:
                        result = "четырнадцать";
                        break;
                    case 15:
                        result = "пятнадцать";
                        break;
                    case 16:
                        result = "шестнадцать";
                        break;
                    case 17:
                        result = "семнадцать";
                        break;
                    case 18:
                        result = "восемнадцать";
                        break;
                    case 19:
                        result = "девятнадцать";
                        break;
                }
            }
            else
            {
                int fd = a / 10;
                switch (fd)
                {
                    case 2:
                        decyatki = "двадцать";
                        break;
                    case 3:
                        decyatki = "тридцать";
                        break;
                    case 4:
                        decyatki = "сорок";
                        break;
                    case 5:
                        decyatki = "пятьдесят";
                        break;
                    case 6:
                        decyatki = "шестьдесят";
                        break;
                    case 7:
                        decyatki = "семьдесят";
                        break;
                    case 8:
                        decyatki = "восемьдесят";
                        break;
                    case 9:
                        decyatki = "девяноста";
                        break;
                }
                int sd = a % 10;
                switch (sd)
                {
                    case 1:
                        edinici = " один";
                        break;
                    case 2:
                        edinici = " два";
                        break;
                    case 3:
                        edinici = " три";
                        break;
                    case 4:
                        edinici = " четыре";
                        break;
                    case 5:
                        edinici = " пять";
                        break;
                    case 6:
                        edinici = " шесть";
                        break;
                    case 7:
                        edinici = " семь";
                        break;
                    case 8:
                        edinici = " восемь";
                        break;
                    case 9:
                        edinici = " девять";
                        break;
                }
                result = decyatki + edinici;
            }
            return result;
        }
        public static string WriteThreeNumbersIncrease(int firstNumber, int secondNumber, int thirdNumber)
        {
            string result="";
            if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
            {
                if (secondNumber >= thirdNumber)
                {
                    result = ($"{thirdNumber},{secondNumber},{firstNumber}");
                }
                else
                {
                    result = ($"{secondNumber},{thirdNumber},{firstNumber}");
                }
            }
            if (secondNumber >= firstNumber && secondNumber >= thirdNumber)
            {
                if (firstNumber >= thirdNumber)
                {
                    result = ($"{thirdNumber},{firstNumber},{secondNumber}");
                }
                else
                {
                    result = ($"{firstNumber},{thirdNumber},{secondNumber}");
                }
            }
            if (thirdNumber >= firstNumber && thirdNumber >= secondNumber)
            {
                if (firstNumber >= secondNumber)
                {
                    result = ($"{secondNumber},{firstNumber},{thirdNumber}");
                }
                else
                {
                    result = ($"{firstNumber},{secondNumber},{thirdNumber}");
                }
            }
            return result;
        }

        public static string SolveSqaureEquation(double a, double b, double c)
        {
            string result = "";
            double x1;
            double x2;
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                result=($"x1={x1},x2={x2}");
            }
            if (D == 0)
            {
                x1 = (-b) / (2 * a);
                result=($"x={x1}");
            }
            if (D < 0)
            {
                result=("no roots");
            }
            return result;

        }
    }
}
