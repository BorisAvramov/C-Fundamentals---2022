using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyId = new Dictionary<string, List<string>>();

                while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = data[0];
                string employeeId = data[1];

                if (!companyId.ContainsKey(companyName))
                {
                    companyId.Add(companyName, new List<string>());
                    companyId[companyName].Add(employeeId);

                }
                else
                {
                    if (!companyId[companyName].Contains(employeeId))
                    {
                        companyId[companyName].Add(employeeId);
                    }
                }


            }
            foreach (var item in companyId.OrderBy(i=>i.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
                //Console.WriteLine(string.Join("\n", item.Value));

            }

        }
    }
}
