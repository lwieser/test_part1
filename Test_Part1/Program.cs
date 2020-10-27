using System;
using Algorithms;

namespace Test_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Veuillez entrer le numérateur");
                int a = InputParser.ParseInt(Console.ReadLine());
                Console.WriteLine("Veuillez entrer le dénominateur");
                int b = InputParser.ParseInt(Console.ReadLine());
                float res = Algorithms.Algorithms.Divide(a, b);
                Console.WriteLine($"Résultat {res}");
            }
        }
    }
}
