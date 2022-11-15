using System;

namespace odwroceniezdania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz zdanie:");
            string zdanie = Console.ReadLine();
            string result = "";
            List<string> listaslow = new List<string>();
            string[] slowa = zdanie.Split(new[] {" "}, StringSplitOptions.None);
            for (int i = slowa.Length - 1; i >= 0; i--)
            {
                result += slowa[i] + " ";
            }
            listaslow.Add(result);
            foreach (String s in listaslow)
            {

                Console.WriteLine("\nOdwrocone zdanie: " + s);
            }
            Console.ReadKey();
        }
      
    }
}