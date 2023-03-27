using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = "";
            int countBlock = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            string pass = Console.ReadLine();

            while (pass != reversed)
            {
                countBlock++;
                if (countBlock == 4)
                {
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                pass = Console.ReadLine();
            }
            if (countBlock != 4)
            {
                Console.WriteLine($"User {input} logged in.");
            }
            else
            {
                Console.WriteLine($"User {input} blocked!");
            }
            

        }
    }
}
