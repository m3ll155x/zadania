using System;

namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, v;
            int z = 0;
            Console.Write("Podaj wartość x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość y: ");
            y = Convert.ToInt32(Console.ReadLine());
            
            if (x <0 && y < 0)
            {

                v = x * y;
                z = v;
            }
            else if (x==0||y == 0)
                {

                v = 10;
                z = v;
                }
                else
                {

                v = x + y;
                z = v;
                }

                Console.WriteLine("Wartość z wynosi:" + z);
            
            Console.ReadKey();
        }
    }
}
