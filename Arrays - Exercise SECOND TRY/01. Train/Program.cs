    using System;

    namespace _01._Train
    {
        class Program
        {
            static void Main(string[] args)
            {
                int nnumberWagons = int.Parse(Console.ReadLine());
                int[] arrWagons = new int[nnumberWagons];
                int allPassengers = 0;
                for (int i = 0; i < nnumberWagons; i++)
                {
                    int curWaonPeiple = int.Parse(Console.ReadLine());
                    arrWagons[i] = curWaonPeiple;
                    allPassengers += curWaonPeiple;

                }

                Console.WriteLine(string.Join(" ", arrWagons ));
                Console.WriteLine(allPassengers);
            }
        }
    }
