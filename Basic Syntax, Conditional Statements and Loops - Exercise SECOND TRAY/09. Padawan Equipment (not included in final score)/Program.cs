using System;

namespace _09._Padawan_Equipment__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double costsLight = (priceLightsabers * countStudents) + (Math.Round(countStudents * 0.1) * priceLightsabers);
            double costRobes = countStudents * priceRobes;
            double costBelts = 0;
            for (int i = 1; i <= countStudents; i++)
            {
                if (i % 6 != 0)
                {
                    costBelts += priceBelts;
                }
            }
            double totalCost = costBelts + costRobes + costsLight;

            if (amount >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }

        }
    }
}
