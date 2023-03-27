using System;
using System.Linq;

namespace _02.Space_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine().Split("||").ToArray();

            int fuel = int.Parse(Console.ReadLine());
            int amunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelRoute.Length; i++)
            {

                string[] commandAndNum = travelRoute[i].Split(" ").ToArray();
                string command = commandAndNum[0];
                int num = 0;
                if (command != "Titan")
                {
                    num = int.Parse(commandAndNum[1]);

                }

                if (command == "Travel")
                {
                    int lightYears = num;

                    if (fuel >= lightYears)
                    {
                        fuel--;
                        Console.WriteLine($"The spaceship travelled {lightYears} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }

                }
                else if (command == "Enemy")
                {
                    int enemyArmor = num;
                    if (amunition >= enemyArmor)
                    {
                        amunition -= enemyArmor;
                        Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                    }
                    else
                    {
                        if ((fuel / 2) >= enemyArmor)
                        {

                            fuel -= 2 * enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");

                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }


                    }

                }
                else if (command == "Repair")
                {
                    int amount = num;
                    fuel += amount;
                    amunition += 2 * amount;
                    Console.WriteLine($"Ammunitions added: {2 * amount}.");
                    Console.WriteLine($"Fuel added: {amount}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    return;
                }
            }
            


        }
    }
}
