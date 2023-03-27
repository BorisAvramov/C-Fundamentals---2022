using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int dailyPlounder = int.Parse(Console.ReadLine());

            double expectedPlounder = double.Parse(Console.ReadLine());

            double totalPlounder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlounder += dailyPlounder;

                if (i % 3 == 0)
                {
                    totalPlounder += dailyPlounder / 2.0;
                }
                if (i % 5 == 0)
                {
                    totalPlounder -= (0.30 * totalPlounder);
                }

            }
            if (totalPlounder >= expectedPlounder)
            {
                Console.WriteLine($"Ahoy! {totalPlounder:f2} plunder gained.");

            }
            else
            {

                Console.WriteLine($"Collected only {(totalPlounder / expectedPlounder) * 100:f2}% of the plunder.");
            }


        }
    }
}
