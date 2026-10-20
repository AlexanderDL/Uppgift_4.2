using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett heltal: ");
            int storsta = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("Vill du skriva ett till heltal? (ja/nej): ");
                string svar = Console.ReadLine().ToLower();

                if (svar != "ja")
                {
                    break;
                }

                Console.Write("Skriv in ett heltal: ");
                int tal = int.Parse(Console.ReadLine());

                if (tal > storsta)
                {
                    storsta = tal;
                }
            }

            Console.WriteLine($"Det största talet du skrev in var: {storsta}");
        }
    }
}