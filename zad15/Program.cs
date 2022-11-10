using System;

namespace zad15
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            int litera;
            Console.Write("Podaj przesuniecie: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Zacznij wpisywać szyfr (q aby zakończyć): ");

            while ((litera = Console.ReadKey(true).KeyChar) != 'q')
            {
                if (litera >= 'a' && litera <= 'z') Console.Write(Convert.ToChar((litera - 'a' + p) % 26 + 'a'));
            }

            Console.ReadKey();
        }
    }
}