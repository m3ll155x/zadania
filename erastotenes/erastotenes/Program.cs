using System;

namespace erastotenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 1000000;


            bool[] lpierwsze = new bool[MAX + 1];
            for (int i = 0; i < lpierwsze.Length; i++)
            {
                lpierwsze[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(MAX) + 1; i++)
            {
                if (lpierwsze[i - 1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= MAX; j += i)
                    {
                        lpierwsze[j - 1] = false;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i < lpierwsze.Length; i++)
            {
                if (lpierwsze[i - 1])
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Istnieje {count} liczb pierwszych do {MAX}");
            Console.ReadKey();
        }
    }
}