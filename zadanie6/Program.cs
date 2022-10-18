using System;

namespace maksimum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("Podaj wartość a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość d: ");
            d = Convert.ToInt32(Console.ReadLine());
            int[] anArray = { a, b, c, d };
            int liczby = anArray.Max();
            Console.WriteLine("Wartość maksymalna wynosi:"+ liczby);
            Console.ReadKey();
        }
    }
}