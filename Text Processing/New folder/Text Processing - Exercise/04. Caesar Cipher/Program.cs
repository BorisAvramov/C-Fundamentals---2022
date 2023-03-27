using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            char[] result = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int currNumChar = (int)input[i] + 3;
                result[i] = (char)currNumChar;

            }

            Console.WriteLine(result);
        }
    }
}
