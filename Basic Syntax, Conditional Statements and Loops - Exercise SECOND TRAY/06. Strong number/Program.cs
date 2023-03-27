using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int tempNum = number;
            int currNum = 0;
            int sumFactorial = 0;
            while (tempNum > 0)
            {
                currNum = tempNum % 10;
                tempNum = tempNum / 10;
                int curFactorial = 1;
                for (int i = 1; i <= currNum; i++)
                {
                    curFactorial *= i;
                }
                sumFactorial += curFactorial;
            }

            if (sumFactorial == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
