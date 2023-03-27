using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, int> dictHeroeHP = new Dictionary<string, int>(); 
            Dictionary<string, int> dictHeroeMP = new Dictionary<string, int>(); 

            for (int i = 1; i <= countHeroes; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string name = data[0];
                int hitPoints = int.Parse(data[1]);
                int manaPoints = int.Parse(data[2]);

                dictHeroeHP.Add(name, hitPoints);
                dictHeroeMP.Add(name, manaPoints);

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] data = input.Split(" - ").ToArray();
                string command = data[0];
                string hereo = data[1];
                if (command == "CastSpell")
                {
                    int manaNeeded = int.Parse(data[2]);
                    string spellName = data[3];
                    if (dictHeroeMP[hereo] >= manaNeeded)
                    {
                        dictHeroeMP[hereo] -= manaNeeded;
                        Console.WriteLine($"{hereo} has successfully cast {spellName} and now has {dictHeroeMP[hereo]} MP!");

                    }
                    else
                    {
                        Console.WriteLine($"{hereo} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(data[2]);
                    string attacker = data[3];

                    if (dictHeroeHP[hereo] > damage)
                    {
                        dictHeroeHP[hereo] -= damage;
                        Console.WriteLine($"{hereo} was hit for {damage} HP by {attacker} and now has {dictHeroeHP[hereo]} HP left!");
                    }
                    else
                    {
                        dictHeroeHP.Remove(hereo);
                        dictHeroeMP.Remove(hereo);
                        Console.WriteLine( $"{hereo} has been killed by {attacker}!");
                    }

                }
                else if (command == "Recharge")
                {
                    int mp = int.Parse(data[2]);
                    //dictHeroeMP[hereo] += mp;
                    if (dictHeroeMP[hereo] + mp > 200)
                    {
                        mp = 200 - dictHeroeMP[hereo]; 
                        dictHeroeMP[hereo] = 200;
                        

                    }
                    else
                    {
                        dictHeroeMP[hereo] += mp;
                    }

                    Console.WriteLine($"{hereo} recharged for {mp} MP!");
                }
                else if (command == "Heal")
                {
                    int hp = int.Parse(data[2]);

                    if (dictHeroeHP[hereo] + hp > 100)
                    {

                        hp = 100 - dictHeroeHP[hereo];
                        dictHeroeHP[hereo] = 100;

                    }
                    else
                    {
                        dictHeroeHP[hereo] += hp;
                    }
                    Console.WriteLine($"{hereo} healed for {hp} HP!");
                }

            }
            foreach (var item in dictHeroeHP)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"HP: {dictHeroeHP[item.Key]}");
                Console.WriteLine($"MP: {dictHeroeMP[item.Key]}");

            }


        }
    }
}
