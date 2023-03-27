using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Points> dict = new Dictionary<string, Points>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string heroName = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                if (hp > 100)
                {
                    hp = 100;
                }
                if (mp > 200)
                {
                    mp = 200;
                }
                dict.Add(heroName, new Points(hp, mp));

                dict[heroName].HitPoints = hp;
                dict[heroName].ManaPoints = mp;

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] data = input.Split(" - ");
                string command = data[0];
                string heroName = data[1];
                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(data[2]);
                    string splellName = data[3];
                    if (mpNeeded <= dict[heroName].ManaPoints)
                    {
                        dict[heroName].ManaPoints -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {splellName} and now has {dict[heroName].ManaPoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {splellName}!");
                    }
                }
                if (command == "TakeDamage")
                {
                    int damage = int.Parse(data[2]);
                    string attacker = data[3];
                    dict[heroName].HitPoints -= damage;
                    if (dict[heroName].HitPoints > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {dict[heroName].HitPoints} HP left!");
                    }
                    else
                    {
                        dict.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                if (command == "Recharge")
                {

                    int amount = int.Parse(data[2]);
                    int amountRecovered = 0;
                    if ((dict[heroName].ManaPoints + amount) > 200)
                    {
                        amountRecovered = 200 - dict[heroName].ManaPoints;
                    }
                    else
                    {
                        amountRecovered = amount;
                    }
                    dict[heroName].ManaPoints += amountRecovered;
                    Console.WriteLine($"{heroName} recharged for {amountRecovered} MP!");

                }
                if (command == "Heal")
                {
                    int amount = int.Parse(data[2]);
                    int amountRecovered = 0;
                    if ((dict[heroName].HitPoints + amount) > 100)
                    {
                        amountRecovered = 100 - dict[heroName].HitPoints;
                    }
                    else
                    {
                        amountRecovered = amount;
                    }
                    dict[heroName].HitPoints += amountRecovered;
                    Console.WriteLine($"{heroName} healed for {amountRecovered} HP!");

                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value.HitPoints}");
                Console.WriteLine($"  MP: {item.Value.ManaPoints}");
            }

        }

    }
    class Points
    {
        public Points(int hitPoints, int manaPoints)
        {
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
