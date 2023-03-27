using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourseQuantity = new Dictionary<string, int>();

            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (resourseQuantity.ContainsKey(resourse))
                {
                    resourseQuantity[resourse] += quantity;
                }
                else
                {
                    resourseQuantity.Add(resourse, quantity);
                }


            }
            foreach (var item in resourseQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
