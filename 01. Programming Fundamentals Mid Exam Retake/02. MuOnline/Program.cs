using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();

            int health = 100;
            int bitcoin = 0;
            bool died = false;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] data = rooms[i].Split(" ");

                string command = data[0];
                int  num = int.Parse(data[1]);

                if (command == "potion")
                {
                    int tempHealth = health;
                    health += num;
                    
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 - tempHealth} hp."); 
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {num} hp.");
                        
                    }
                    Console.WriteLine($"Current health: {health} hp.");

                }
                else if (command == "chest")
                {
                    bitcoin += num;
                    Console.WriteLine($"You found {num} bitcoins.");
                }
                else
                {
                    health -= num;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        died = true;
                        break;
                    }
                }


            }

            if (!died)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoin}");
                Console.WriteLine($"Health: {health}");

            }

        }
    }
}
