using System;

namespace sumailoczyn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            var iloczyn = 1;

            int n, przezCoPodzielna, kolejnaPodzielna;

            Console.Write("Podaj wartosc zmiennej n\n> ");
            var nstring = Console.ReadLine();
            n = Int32.Parse(nstring);

            Console.Write("\nPodaj wartosc zmiennej k\n> ");
            var kstring = Console.ReadLine();
            przezCoPodzielna = Int32.Parse(kstring);

            kolejnaPodzielna = przezCoPodzielna;

            foreach (var i in Enumerable.Range(1, n))
            {
                suma += kolejnaPodzielna;
                iloczyn *= kolejnaPodzielna;
                kolejnaPodzielna += przezCoPodzielna;
            }

            Console.WriteLine("\nsuma: {0}\niloczyn: {1}", suma, iloczyn);
            Console.ReadKey();
        }

    }
}
