using System;

namespace PROBA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            double num2 = 12.5;
            double num3 = num1 / num2;
            Console.WriteLine(num3);
            num3 = Math.Floor(num3);
            Console.WriteLine(num3);
        }
    }
}
