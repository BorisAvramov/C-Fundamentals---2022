using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> regUsersPlates = new Dictionary<string, string>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                

                if (input[0] == "register")
                {
                    string userName = input[1];
                    string plateNumber = input[2];
                    if (!regUsersPlates.ContainsKey(userName))
                    {
                        regUsersPlates.Add(userName, plateNumber);
                        Console.WriteLine($"{userName} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {regUsersPlates[userName]}");

                    }

                }
                else if (input[0] == "unregister")
                {
                    string userName = input[1];
                    if (!regUsersPlates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {

                        Console.WriteLine($"{userName} unregistered successfully");

                        regUsersPlates.Remove(userName);
                    }


                }

            }

            foreach (var user in regUsersPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}
