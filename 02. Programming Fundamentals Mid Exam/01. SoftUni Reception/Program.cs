using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEmplEfPerHour = 0;
            
            for (int i = 1; i <= 3; i++)
            {
                int empEfPerHour = int.Parse(Console.ReadLine());
                totalEmplEfPerHour += empEfPerHour;

            }

            int studentsCount = int.Parse(Console.ReadLine());

            int timeNeeded = 0;


            while (true)
            {

                if ( studentsCount <= 0)
                {

                    break;

                }
                timeNeeded++;
                if (timeNeeded % 4 != 0)
                {
                    studentsCount -= totalEmplEfPerHour;

                }



            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");


        }
    }
}
