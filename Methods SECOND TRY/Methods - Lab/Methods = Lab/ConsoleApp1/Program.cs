using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            SignTTT();

        }

            static void SignTTT()
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    Console.WriteLine($"The number {number} is zero.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else
                {
                    Console.WriteLine($"The number - {number} is positive.");
                }
            }
            
        
    }
}
