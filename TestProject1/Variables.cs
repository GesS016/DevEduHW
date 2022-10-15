namespace TestProject1
{
    public static class Variables
    {
        public static int SolveExample(int a, int b) //2
        {
            int result = (5 * a + b * b) / (b - a);
            return result;
        }

        public static int SolveEquation(int a, int b, int c) //4
        {
            int result = (c - b) / a;
            return result;
        }

        public static string FindStraightLineEquation(int x1, int y1, int x2, int y2) //5
        {
            int a = (y2 - y1) / (x2 - x1);
            int b = y2 - a * x2;
            string result;
            return result=($"y={a}x+{b}"); 
        }
    }
}
