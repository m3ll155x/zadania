using System;

namespace zmianaznakow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj slowo:");
            string slowo = Console.ReadLine();
            Console.WriteLine(zamiana(slowo));
            Console.ReadKey();
        }
        public static string zamiana(string input)
        {
            return input.Length > 1
                ? input.Substring(input.Length - 1) + input.Substring(1, input.Length - 2) + input.Substring(0, 1) : input;
        }
        
    }
}