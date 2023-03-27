using System;
using System.Linq;

namespace _03._The_Angry_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] itemPriceRatings = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int entryIndex = int.Parse(Console.ReadLine());

            string cheapOrExpen = Console.ReadLine();

            int leftPriceRating = 0;
            int rightPriceRating = 0;

            for (int i = 0; i < entryIndex; i++)
            {
                if (cheapOrExpen == "cheap")
                {
                    if (itemPriceRatings[i]  < itemPriceRatings[entryIndex])
                    {
                        leftPriceRating += itemPriceRatings[i];
                    }
                }
                else if (cheapOrExpen == "expensive")
                {
                    if (itemPriceRatings[i] >= itemPriceRatings[entryIndex])
                    {
                        leftPriceRating += itemPriceRatings[i];
                    }
                }
            }
            for (int i = entryIndex+1; i < itemPriceRatings.Length; i++)
            {
                if (cheapOrExpen == "cheap")
                {
                    if (itemPriceRatings[i] < itemPriceRatings[entryIndex])
                    {
                        rightPriceRating += itemPriceRatings[i];
                    }
                }
                else if (cheapOrExpen == "expensive")
                {
                    if (itemPriceRatings[i] >= itemPriceRatings[entryIndex])
                    {
                        rightPriceRating += itemPriceRatings[i];
                    }
                }


            }

            string position;
            if (leftPriceRating == rightPriceRating)
            {
                position = "Left";
                Console.WriteLine($"{position} - {leftPriceRating}");
            }
            else if (leftPriceRating > rightPriceRating)
            {
                position = "Left";
                Console.WriteLine($"{position} - {leftPriceRating}");

            }
            else
            {
                position = "Right";
                Console.WriteLine($"{position} - {rightPriceRating}");

            }


        }
    }
}
