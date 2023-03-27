using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            int move = 0;
            string input = Console.ReadLine();
            while (input != "end")
            {
                move++;

                string[] data = input.Split();

                int index1 = int.Parse(data[0]);
                int index2 = int.Parse(data[1]);
                
                if (index1 == index2 || index1 < 0 || index1 > elements.Count - 1 || index2 < 0 || index2 > elements.Count - 1)
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        elements.Insert((elements.Count / 2), $"-{move}a");
                       

                    }
                    Console.WriteLine("Invalid input! Adding additional elements to the board");

                }
                else if (elements[index1] == elements[index2])
                {

                    
                    string tempEl = elements[index1];   
                    elements.Remove(tempEl);
                    elements.Remove(tempEl);
                    Console.WriteLine($"Congrats! You have found matching elements - {tempEl}!");
                }
                else if (elements[index1] != elements[index2])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {move} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
           
        }
    }
}
