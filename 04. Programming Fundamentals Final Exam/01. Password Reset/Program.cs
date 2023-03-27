using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string otherInput = "";
            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "Done")
                {
                    break;
                }

                string[] data = input2.Split();
                string command = data[0];
                if (command == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            otherInput += input[i];
                        }

                    }
                    input = otherInput.ToString();
                    Console.WriteLine(input);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(data[1]);
                    int lenght = int.Parse(data[2]);

                    
                    
                        string substring = input.Substring(index, lenght);

                        int startIndex = input.IndexOf(substring);
                        input = input.Remove(startIndex, lenght);
                        Console.WriteLine(input);
                    
                }
                else if (command == "Substitute")
                {
                    string substring = data[1];
                    string substitute = data[2];

                    if (input.Contains(substring))
                    {
                        input = input.Replace(substring, substitute);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }


            }


            Console.WriteLine($"Your password is: {input}");

        }
    }
}
