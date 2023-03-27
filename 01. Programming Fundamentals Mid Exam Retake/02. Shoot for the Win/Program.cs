using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                int index = int.Parse(input);

                
                    if (index >= 0 && index < targets.Length)
                    {
                    if (targets[index] != -1)
                    {
                        int currValue = targets[index];
                        targets[index] = -1;
                        count++;

                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > currValue)
                                {
                                    targets[i] -= currValue;
                                }
                                else
                                {
                                    targets[i] += currValue;
                                }

                            }


                        }
                    }
                   
                    }
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");


        }
    }
}
