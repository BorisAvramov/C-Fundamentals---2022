using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = GetNewString(input, count);
            Console.WriteLine(result);

        }

        private static string GetNewString(string input, int count)
        {
            string newString = "";

            for (int i = 1; i <= count; i++)
            {
                newString += input;
            }
            return newString;

        }
    }
}
