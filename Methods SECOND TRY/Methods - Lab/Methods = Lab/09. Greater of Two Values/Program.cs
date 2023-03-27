using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeInput = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            switch (typeInput)
            {
                case "int":
                    GetResultInt(input1, input2);
                    break;
                case "char":
                    GetResultChar(input1, input2);
                    
                    break;
                case "string":
                    GetResultString(input1, input2);
                    break;
                default:
                    break;
            }




        }

        private static void GetResultString(string input1, string input2)
        {
            if (input1.Length != input2.Length)
            {
                if (input1.Length > input2.Length)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input2);
                }
            }
            else if (input1.Length == input2.Length)
            {
                int sumInput1 = 0;
                int sumInput2 = 0;
                for (int i = 0; i < input1.Length; i++)
                {
                    sumInput1 += input1[i];
                }
                for (int i = 0; i < input2.Length; i++)
                {
                    sumInput2 += input2[i];
                }
                if (sumInput1 > sumInput2)
                {
                    Console.WriteLine(input1);
                }
                else
                {
                    Console.WriteLine(input);
                }


            }


        }

        private static void GetResultChar(string input1, string input2)
        {
            char char1 = char.Parse(input1);
            char char2 = char.Parse(input2);
            if (char1 > char2 )
            {
                Console.WriteLine(char1);
            }
            else
            {
                Console.WriteLine(char2);
            }

        }
        private static void GetResultInt(string input1, string input2)
        {
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }

        }

        
    }
}
