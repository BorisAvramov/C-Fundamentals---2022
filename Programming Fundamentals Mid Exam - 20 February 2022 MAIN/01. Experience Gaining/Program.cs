using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperince = double.Parse(Console.ReadLine());

            int countBatlles = int.Parse(Console.ReadLine());

            double recievedExp = 0;

            for (int i = 1; i <= countBatlles; i++)
            {
                double currExpPerBatlle = double.Parse(Console.ReadLine());
                if (i % 3  == 0)
                {
                    currExpPerBatlle += currExpPerBatlle * 0.15;
                }
                if (i % 5 == 0)
                {
                    currExpPerBatlle -= currExpPerBatlle * 0.1;
                }
                if (i % 15 == 0)
                {
                    currExpPerBatlle += currExpPerBatlle * 0.05;
                }
                recievedExp += currExpPerBatlle;


                if (recievedExp >= neededExperince)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }


            }

            Console.WriteLine($"Player was not able to collect the needed experience, {neededExperince - recievedExp:f2} more needed.");




        }
    }
}
