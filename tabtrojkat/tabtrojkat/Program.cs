using System;

namespace tabtrojkat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            piramida();
            Console.ReadKey();
        }
        static void piramida()
        {
            int[] arr = Enumerable.Range(1, 100).ToArray();
            int n,m;
            n = 14;
            int k;
            k = 100;
            m = 8;
            for (int i = 0; i < n; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    k--;
                    Console.Write(arr[k] + " ");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write(arr[m] + " ");
                m--;
            }

        }
    }
}
