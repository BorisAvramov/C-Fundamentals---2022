using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];

                if (command == "Change")
                {
                    char charToReplace = char.Parse(data[1]);
                    char replacementChar = char.Parse(data[2]);

                    inputString = inputString.Replace(charToReplace,replacementChar);
                    Console.WriteLine(inputString);

                }
                if (command == "Includes")
                {
                    string stringIfIncludes = data[1];
                    if (inputString.Contains(stringIfIncludes))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                if (command == "End")
                {
                    string substring = data[1];
                    int lastIndexOf = inputString.LastIndexOf(substring);
                    if ((lastIndexOf + substring.Length) == inputString.Length)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                if (command == "Uppercase")
                {

                    inputString = inputString.ToUpper();
                    Console.WriteLine(inputString);

                }
                if (command == "FindIndex")
                {
                    int firstIndexOfChar = inputString.IndexOf(char.Parse(data[1]));
                    Console.WriteLine(firstIndexOfChar);
                }
                if (command == "Cut")
                {
                    int startIndex = int.Parse(data[1]);
                    int count = int.Parse(data[2]);

                    string substring = inputString.Substring(startIndex, count);
                    inputString = substring;
                    Console.WriteLine(substring);
                }


            }

        }
    }
}
