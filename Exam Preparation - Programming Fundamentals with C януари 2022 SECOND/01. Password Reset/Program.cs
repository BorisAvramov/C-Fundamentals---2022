using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string input2 = Console.ReadLine();

            while (input2 != "Done")
            {
                string[] data = input2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];

                if (command == "TakeOdd")
                {
                    string password = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            password += input[i];
                        }
                    }
                    input = password;
                }
                if (command == "Cut")
                {
                    int index = int.Parse(data[1]);
                    int lenght = int.Parse(data[2]);
                    string substring = input.Substring(index, lenght);
                    input = input.Remove(index,lenght);
                }
                if (command == "Substitute")
                {
                    string substring = data[1];
                    string substitute = data[2];
                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        input2 = Console.ReadLine();
                        continue;
                    }

                }
                Console.WriteLine(input);
                input2 = Console.ReadLine();

            }

            Console.WriteLine($"Your password is: {input}");

        }
    }
}
