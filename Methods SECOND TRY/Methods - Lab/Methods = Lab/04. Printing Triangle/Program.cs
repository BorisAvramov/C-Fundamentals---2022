using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            TopTriangle(num);
            BottomTriangle(num);

            
        }

        private static void BottomTriangle(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j+" ");

                }
                Console.WriteLine();
            }


        }

        private static void TopTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();


            }


        }
    }
}
