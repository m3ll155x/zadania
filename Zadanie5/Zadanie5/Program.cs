using System;

namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę 1:");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 2:");
            int liczba2 = Convert.ToInt32(Console.ReadLine());
            var liczby = new int[] { liczba1, liczba2 };
            double srednia = Queryable.Average(liczby.AsQueryable());
            Console.WriteLine("Średnia to: " + srednia);
            Console.ReadKey();
        }
    }
}