using System;
using System.Diagnostics;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input ==  "end")
                {
                    break;
                }

                StringBuilder sbInput = new StringBuilder();

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    sbInput.Append(input[i]);


                }
                Console.WriteLine($"{input} = {sbInput}");

                //------------------------------------

                //char[] charInput = input.ToCharArray();
                //string reversed = "";
                //for (int i = input.Length - 1; i >= 0; i--)
                //{
                //    reversed += input[i];
                //}

                //-------------------------------------------------

                //string reversed = "";
                //int index = input.Length - 1;
                //for (int i = 0; i < input.Length; i++)
                //{

                //    reversed += input[index];
                //    index--;

                //}

                //Console.WriteLine($"{input} = {reversed}");

                
            }

        }
    }
}
