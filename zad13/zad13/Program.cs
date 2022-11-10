using System;

namespace zad13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, b, c, delta, x1, x2;
                Console.WriteLine("Podaj wartosc parametru a:");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception("Parametr a musi być rózny od zera");
                }
                Console.WriteLine("Podaj wartosc parametru b:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wartosc parametru c:");
                c = Convert.ToDouble(Console.ReadLine());

                delta = (b * b) - (4 * a * c);
                if (delta > 0)
                {
                    x1 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
                    x2 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Rownanie ma dwa pierwiastki");
                    Console.WriteLine("\tx1 = {0}", x1);
                    Console.WriteLine("\tx2 = {0}", x2);
                    Console.ReadKey(true);
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Równanie ma jeden pierwiastek rzeczywisty");
                    Console.WriteLine("\tx1 = {0}", x1);
                }
                else
                {
                    Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program został przerwany - {0}", ex.Message);
                Console.ReadKey(true);
            }

        }
    }
}