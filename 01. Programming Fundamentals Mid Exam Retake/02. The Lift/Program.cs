using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int [] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int i = 0; i < lift.Length; i++)
                {
                    if (lift[i] < 4)
                    {
                    int tempPeopleWait = peopleWaiting;
                        peopleWaiting -= 4 - lift[i];
                        if (peopleWaiting <= 0)
                        {
                        lift[i] = lift[i] + tempPeopleWait;
                            break;
                        }
                    lift[i] = 4;
                    }


                }
            if (peopleWaiting <= 0 )
            {
                bool emptySpaces = false;

                for (int i = 0; i < lift.Length; i++)
                {
                    if (lift[i] < 4)
                    {
                        emptySpaces = true;
                    }
                }
                if (emptySpaces)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(string.Join(" ", lift));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", lift));
                }


            }
            else
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            

        }
    }
}
