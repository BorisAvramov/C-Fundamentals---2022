using System;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] pirateShipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
             int[] warShipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToArray();

            int maxHealthCapASection = int.Parse(Console.ReadLine());

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Retire")
                {
                    break;
                }
                string[] data = input.Split().ToArray();

                if (data[0] == "Fire")
                {
                    int index = int.Parse(data[1]);
                    int damage = int.Parse(data[2]);
                    if (index < 0 || index > warShipStatus.Length - 1)
                    {
                        continue;
                    }
                    warShipStatus[index] -= damage;
                    if (warShipStatus[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }

                }
                else if (data[0] == "Defend")
                {
                    int index1 = int.Parse(data[1]);
                    int index2 = int.Parse(data[2]);
                    int damage = int.Parse(data[3]);
                    if ((index1 < 0 || index1 > pirateShipStatus.Length - 1) || (index2 < 0 || index2 > pirateShipStatus.Length - 1) || index1 > index2)
                    {
                        continue;
                    }
                    for (int i = index1; i <= index2; i++)
                    {
                        pirateShipStatus[i] -= damage;
                        if (pirateShipStatus[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
                else if (data[0] == "Repair")
                {
                    int index = int.Parse(data[1]);
                    int health = int.Parse(data[2]);
                    if (index < 0 || index > pirateShipStatus.Length - 1)
                    {
                        continue;
                    }
                    pirateShipStatus[index] += health;
                    if (pirateShipStatus[index] > maxHealthCapASection)
                    {
                        pirateShipStatus[index] = maxHealthCapASection;
                    }


                }
                else if (data[0] == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShipStatus.Length; i++)
                    {
                        if (pirateShipStatus[i] < (maxHealthCapASection * 0.2))
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }


            }

            Console.WriteLine($"Pirate ship status: {pirateShipStatus.Sum()}");
            Console.WriteLine($"Warship status: {warShipStatus.Sum()}");

        }
    }
}
