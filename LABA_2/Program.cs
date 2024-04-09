using System;
using static System.Net.Mime.MediaTypeNames;

namespace MyFuncLib
{
    public class Functions
    {
        public static double SinTaylor(double x)
        {
            if (x > 4 || x < -4)
            {
                return -1;
            }
            double result = 0;
            for (int n = 0; n < 10; n++)
            {
                result += Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1);
            }
            return result;
        }


        public static double CosTaylor(double x)
        {
            if (x > 4 || x < -4)
            {
                return -1;
            }
            double result = 0;
            for (int n = 0; n < 10; n++)
            {
                result += Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
            }
            return result;
        }

        public static double LogTaylor(double x)
        {
            if (x <= 0 || x >= 2)
            {
                return -1;
            }

            double result = 0;
            for (int n = 1; n <= 200; n++)
            {
                double term = Math.Pow(-1, n - 1) * Math.Pow(x - 1, n) / n;
                result += term;
            }
            return result;
        }

        public static long Factorial(long n)
        {
            if (n < 0 || n > 25)
            {
                return -1;
            }
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                long result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                return result;
            }
        }

        public static double firststmt(double x)
        {
            double sinSquared = SinTaylor(x) * SinTaylor(x);
            double expTerm = Math.Exp(2 * x);
            double cosTerm = CosTaylor(3 * x);
            return Math.Round(sinSquared / (expTerm + cosTerm), 3);
        }

        public static double secondstmt(double x)
        {
            double sqrtTerm = Math.Round(Math.Sqrt(x * x + 1), 3);
            double lnTerm = LogTaylor(x * x);
            return sqrtTerm - lnTerm;
        }

        public static double MainFunc(double x)
        {
            if (x < 0)
            {
                return firststmt(x);
            }
            else
            {
                return secondstmt(x);
            }
        }

        static void Main(string[] args)
        {
        }
    }

}
