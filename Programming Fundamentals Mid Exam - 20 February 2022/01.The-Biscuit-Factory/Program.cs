using System;

namespace _01.The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitProducedPerDayBuWorker = int.Parse(Console.ReadLine());

            int countWorkers = int.Parse(Console.ReadLine());

            int totalBuscuitsCOmpeteFactoryPerMonth = int.Parse(Console.ReadLine());

            int buscuitsPerDayByAllWorkers = countWorkers * biscuitProducedPerDayBuWorker;

            double totalBusciotsPerMonth = 0;
            //11 23
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    double buscuitsProduced3Day = Math.Floor(buscuitsPerDayByAllWorkers * 0.75);
                    totalBusciotsPerMonth += buscuitsProduced3Day;
                }
                else
                {
                    totalBusciotsPerMonth += buscuitsPerDayByAllWorkers;
                }

            }
            Console.WriteLine($"You have produced {totalBusciotsPerMonth} biscuits for the past month.");

            //350  148
            //double totalBusciotsPerMonth =350;
            //int totalBuscuitsCOmpeteFactoryPerMonth = 148;
            if (totalBusciotsPerMonth > totalBuscuitsCOmpeteFactoryPerMonth)
            {
                double percentDiffrence = ((totalBusciotsPerMonth - totalBuscuitsCOmpeteFactoryPerMonth) / totalBuscuitsCOmpeteFactoryPerMonth) * 100;
                Console.WriteLine($"You produce {percentDiffrence:f2} percent more biscuits.");
            }
            else if (totalBuscuitsCOmpeteFactoryPerMonth > totalBusciotsPerMonth)
            {
                double percentDiff = ((totalBuscuitsCOmpeteFactoryPerMonth - totalBusciotsPerMonth) / totalBusciotsPerMonth) * 100;
                Console.WriteLine($"You produce {percentDiff:f2} percent less biscuits.");
            }

        }
    }
}
