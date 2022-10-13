using System;

namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            int liczba = int.Parse(Console.ReadLine());


            if (liczba % 2 == 0)
            {
                Console.WriteLine("Podana liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Podana liczba jest nieparzysta.");
            }
            Console.ReadKey();
        }
    }
}