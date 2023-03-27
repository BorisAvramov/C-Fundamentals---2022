using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numMaxdivisible = 0;
            bool isDivisible = false;
            if (num % 2 == 0)
            {
                numMaxdivisible = 2;
                isDivisible = true;
            }
            if (num % 3 == 0)
            {
                numMaxdivisible = 3;
                isDivisible = true;

            }
            if (num % 6 == 0)
            {
                numMaxdivisible = 6;
                isDivisible = true;

            }
            if (num % 7 == 0)
            {
                numMaxdivisible = 7;
                isDivisible = true;

            }
            if (num % 10 == 0)
            {
                numMaxdivisible = 10;
                isDivisible = true;

            }
            if (isDivisible)
            {
                Console.WriteLine($"The number is divisible by {numMaxdivisible}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
