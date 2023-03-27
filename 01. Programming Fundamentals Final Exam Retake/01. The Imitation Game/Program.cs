using System;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string mmassage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] data = input.Split('|',StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];

                if (command == "Move")
                {
                    int nLetters = int.Parse(data[1]);
                    string subStringToMove = mmassage.Substring(0, nLetters);
                    mmassage = mmassage.Remove(0, nLetters);
                    mmassage += subStringToMove;

                }
                if (command == "Insert")
                {
                    mmassage = mmassage.Insert(int.Parse(data[1]), data[2]);

                }
                if (command == "ChangeAll")
                {
                    if (mmassage.Contains(data[1]))
                    {
                        mmassage = mmassage.Replace(data[1], data[2]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {mmassage}");

        }
    }
}
