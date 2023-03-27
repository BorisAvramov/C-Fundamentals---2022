using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            switch (command)
            {
                case "add":
                    add(num1, num2);
                    break;
                case "multiply":
                    multiplY(num1, num2);
                    break;
                case "subtract":
                    subtract(num1, num2);
                    break;
                case "divide":
                    divide(num1, num2);
                    break;
                default:
                    break;
            }

            
        }

        private static void divide(int num1, int num2)
        {

            double result = num1 / num2;
            Console.WriteLine(result);

        }

        private static void subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);

        }

        private static void multiplY(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);

        }

        private static void add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
