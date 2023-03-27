using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            GetMultipleOfEvenAndOdds(num);
            
            
        }

        private static void GetMultipleOfEvenAndOdds(int num)
        {
            int sumEven = GetSumOfEvenDigits(num);
            int sumOdd = GetSumOfOddDigits(num);

            Console.WriteLine(sumEven * sumOdd);

        }

        private static int GetSumOfOddDigits(int num)
        {
            int sumOdd = 0;
            while (num != 0)
            {
                int currNum = num % 10;
                if (currNum % 2 != 0)
                {
                    sumOdd += currNum;
                }
                num = num / 10;

            }
            return sumOdd;

        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sumEvenNum = 0;
            
            while (num != 0)
            {
                int curNum = num % 10;
                if (curNum % 2 == 0)
                {
                    sumEvenNum += curNum;
                }
                num = num / 10;


            }

            return sumEvenNum;
        }

       
    }
}
