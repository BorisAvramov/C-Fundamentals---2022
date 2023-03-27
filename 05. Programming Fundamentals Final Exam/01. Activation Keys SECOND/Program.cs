using System;

namespace _01._Activation_Keys_SECOND
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActKey = Console.ReadLine();

            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2 == "Generate")
                {
                    break;
                }

                string[] data = input2.Split(">>>");
                string command = data[0];
                if (command == "Contains")
                {
                    string substring = data[1];
                    if (rawActKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActKey} contains {substring}");

                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                        continue;
                    }

                }
                if (command == "Flip")
                {
                    string upperOrLower = data[1];
                    int startIndex = int.Parse(data[2]);
                    int endIndex = int.Parse(data[3]);

                    string oldSubstring = rawActKey.Substring(startIndex, endIndex - startIndex);

                    if (upperOrLower == "Upper")
                    {
                        //string eited = rawActKey.Substring(0, startIndex) + rawActKey.Substring(startIndex, endIndex - startIndex).ToUpper() + rawActKey.Substring(endIndex);
                        
                        
                        
                        string eited = rawActKey.Remove(startIndex, endIndex - startIndex);
                        eited = eited.Insert(startIndex, oldSubstring.ToUpper());
                        rawActKey = eited;
                        Console.WriteLine(rawActKey);

                    }
                    if (upperOrLower == "Lower")
                    {
                        //string eited = rawActKey = rawActKey.Substring(0, startIndex) + rawActKey.Substring(startIndex, endIndex - startIndex).ToLower() + rawActKey.Substring(endIndex); ;
                        //rawActKey = eited;
                        //Console.WriteLine(rawActKey);
                        string eited = rawActKey.Remove(startIndex, endIndex - startIndex);
                        eited = eited.Insert(startIndex, oldSubstring.ToLower());
                        rawActKey = eited;
                        Console.WriteLine(rawActKey);
                    }

                }
                if (command == "Slice")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);
                    string edited  = rawActKey.Remove(startIndex, endIndex - startIndex);
                    rawActKey = edited;
                    Console.WriteLine(edited);

                }
            }


            Console.WriteLine($"Your activation key is: {rawActKey}");
        }
    }
}
