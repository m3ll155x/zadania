using System;

namespace zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n, x;
            int dz = 0;
            Console.WriteLine("Podaj m:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());

            if (m > n)
            {
                x = n;
                n = m;
                m = x;
            }
            while (n != 0)
            {
                dz = m % n;
                m = n;
                if (dz == 0)
                {
                    dz = n;
                    n = 0;
                }
                else
                {
                    n = dz;
                }
            }

            Console.WriteLine("Najwiekszy wspolny dzielnik podanych liczb to: " + dz);
            Console.ReadKey();
        }
    }
}

//zrobilam troszke inaczej niz bylo wskazane w poleceniu (brak uzycia roznicy), ale mam nadzieje ze mozna bylo w ten sposob wykonac zadanie:)//