namespace BranchStructures

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
        else if (x == 0)
        {
            result = "on Y axis";
        }
        else
        {
            result = "on X axis";
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
                    decyatki = "двадцать ";
                    break;
                case 3:
                    decyatki = "тридцать ";
                    break;
                case 4:
                    decyatki = "сорок ";
                    break;
                case 5:
                    decyatki = "пятьдесят ";
                    break;
                case 6:
                    decyatki = "шестьдесят ";
                    break;
                case 7:
                    decyatki = "семьдесят ";
                    break;
                case 8:
                    decyatki = "восемьдесят ";
                    break;
                case 9:
                    decyatki = "девяноста ";
                    break;
            }
            int sd = a % 10;
            switch (sd)
            {
                case 1:
                    edinici = "один";
                    break;
                case 2:
                    edinici = "два";
                    break;
                case 3:
                    edinici = "три";
                    break;
                case 4:
                    edinici = "четыре";
                    break;
                case 5:
                    edinici = "пять";
                    break;
                case 6:
                    edinici = "шесть";
                    break;
                case 7:
                    edinici = "семь";
                    break;
                case 8:
                    edinici = "восемь";
                    break;
                case 9:
                    edinici = "девять";
                    break;
            }
            result = decyatki + edinici;
        }
        return result;
    }
}