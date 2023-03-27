using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            string secondString = Console.ReadLine();

            while (secondString.Contains(word))
            {

                int startIndex = secondString.IndexOf(word);


               secondString = secondString.Remove(startIndex, word.Length);
            }

            Console.WriteLine(secondString);

        }
    }
}
