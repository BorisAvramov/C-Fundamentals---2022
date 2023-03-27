using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetPower(num, power));

        }

        private static double GetPower(double num, int power)
        {
             double result = Math.Pow(num, power);
            return result;
        }
    }
}
