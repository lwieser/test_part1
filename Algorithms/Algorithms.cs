using System;
using System.Linq;
using System.Threading;

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

            var reversed = word.Reverse();
            var reversedWord = String.Join("", reversed);
            return reversedWord.Equals(word, StringComparison.CurrentCultureIgnoreCase);
        }
        //
        // public static int PGCD(int a, int b)
        // {
        //     if (a == 0 || b == 0) return 0;
        //     int rest = a % b;
        //     return rest == 0 ? b : PGCD(b, rest);
        // }

        public static int PGCD(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
        
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            var pgcd = min;
            var rest = GetRest(min, max);
            while (rest != 0)
            {
                max = min;
                min = rest;
                rest = GetRest(max, min);
                pgcd = min;
            }
        
            return pgcd;
        }
        
        public  static int GetRest(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            var divisionResult = max / min;
            var rest = max - min * divisionResult;
            return rest;
        }

        public static string CorrectText(string text)
        {
            if (text == null) return null;

            var sentences = text.Split('.');
            var correctedSentences = new string[sentences.Length];
            var res = "";
            for (int i = 0; i < sentences.Length; i++)
            {
                var corrected = CorrectSentence(sentences[i]);
                if (!String.IsNullOrEmpty(corrected))
                {
                    res += corrected ;
                }

            }

            return res;
        }

        public static string CorrectSentence(string text)
        {
            if (String.IsNullOrEmpty(text)) return text;

            text = text.Substring(0, 1).ToUpper() + text.Substring(1);
            if (text.Last() != '.')
            {
                text += ".";
            }

            return text;
        }
    }
}
