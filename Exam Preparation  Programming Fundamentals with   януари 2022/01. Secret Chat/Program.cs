using System;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Reveal")
                {
                    break;
                }

                string[] data = input.Split(":|:",StringSplitOptions.RemoveEmptyEntries);

                string command = data[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(data[1]);

                    massage = massage.Insert(index, " ");
                }
                if (command == "Reverse")
                {
                    string substring = data[1];

                    if (massage.Contains(substring))
                    {
                        int startIndex = massage.IndexOf(substring);
                        massage = massage.Remove(startIndex, substring.Length);
                        string substringReversed = "";
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            substringReversed += substring[i];
                        }
                        massage = massage + substringReversed;
                        

                    }
                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
                if (command == "ChangeAll")
                {
                    string substring = data[1];
                    string repplacment = data[2];

                    massage = massage.Replace(substring, repplacment);

                }
                Console.WriteLine(massage);

            }

            Console.WriteLine($"You have a new text message: {massage}");

        }
    }
}
