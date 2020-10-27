using System;
using System.Linq;

namespace Algorithms
{
    public class Algorithms
    {
        public static float Divide(int a, int b)
        {
            if (b == 0) return a;

            return (float)a / (float)b;
        }

        public static int[] Fibonacci(int length)
        {
            if (length < 0)
            {
                length = 0;
            }

            int[] res = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == 1)
                {
                    res[i] = i;
                }
                else
                {
                    res[i] = res[i - 1] + res[i - 2];
                }
            }

            return res;
        }

        public static bool IsPalindrome(string word)
        {
            if (word == null) return false;
            return String.Join("", word.Reverse()).Equals(word, StringComparison.CurrentCultureIgnoreCase);
        }
        public static int PGCD(int a, int b)
        {
            return 0;
        }
        public static string CorrectText(string text)
        {
            return null;
        }
    }
}
