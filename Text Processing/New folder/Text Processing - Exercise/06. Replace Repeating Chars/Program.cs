using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //input.Substring();
            //input.Replace();
            int lenght = 0;
            int startIndex = 0;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                lenght++;
                if (i != input.Length-1)
                {
                    if (input[i] != input[i + 1])
                    {

                        string toReplace = input.Substring(startIndex, lenght);
                        input = input.Replace(toReplace, new string(input[i], 1));
                        startIndex++;
                        lenght = 0;
                        count++;
                        i = count - 1;

                    }
                }
                else
                {
                    string toReplace = input.Substring(startIndex, lenght);
                    input = input.Replace(toReplace, new string(input[i], 1));
                }
                    
                
            }

            Console.WriteLine(input);


        }
    }
}
