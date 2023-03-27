using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] daysName = {"Monday", "Tuesday", "Wednsday", "Tuersday", "Friday", "Saturday", "Sunday"};

            if (num >= 1 && num <= 7)
            {   
                Console.WriteLine(daysName[num - 1]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }

        }
    }
}
