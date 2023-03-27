using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sbInput = new StringBuilder();

            Match match = Regex.Match(input, @"^[A-Za-z0-9]+$");

            if (match.Success)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    sbInput.Append(input[i]);
                }
                while (true)
                {
                    string input2 = Console.ReadLine();

                    if (input2 == "Generate")
                    {
                        break;
                    }
                    string[] data = input2.Split(">>>").ToArray();
                    if (data[0] == "Contains")
                    {

                        string sbTostring = sbInput.ToString();

                        if (sbTostring.Contains(data[1]))
                        {
                            Console.WriteLine($"{sbInput} contains {data[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        continue;
                    }

                    else if (data[0] == "Slice")
                    {
                        int startIndex = int.Parse(data[1]);
                        int lastIndex = int.Parse(data[2]);

                        sbInput = sbInput.Remove(startIndex, lastIndex - startIndex);

                    }
                    else if (data[0] == "Flip")
                    {
                        int startIndex = int.Parse(data[2]);
                        int lastIndex = int.Parse(data[3]);

                        if (data[1] == "Upper")
                        {
                            for (int i = startIndex; i < lastIndex; i++)
                            {
                                if (char.IsLetter(sbInput[i]))
                                {
                                    if (sbInput[i] >= 'a' && sbInput[i] <= 'z')
                                    {
                                        sbInput[i] = (char)(sbInput[i] - 32);
                                    }



                                }
                            }

                        }
                        else
                        {
                            for (int i = startIndex; i < lastIndex; i++)
                            {
                                if (char.IsLetter(sbInput[i]))
                                {
                                    if (sbInput[i] >= 'A' && sbInput[i] <= 'Z')
                                    {

                                        sbInput[i] = (char)(sbInput[i] + 32);

                                    }


                                }
                            }
                        }

                    }
                     
                    
                   
                        Console.WriteLine(sbInput);
                    


                }

                Console.WriteLine($"Your activation key is: {sbInput}");

            }
        }
    }
}
