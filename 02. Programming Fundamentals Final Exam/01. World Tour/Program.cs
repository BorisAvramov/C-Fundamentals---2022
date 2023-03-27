using System;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputStops = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] data = input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                if (command == "Add Stop")
                {
                    int index = int.Parse(data[1]);
                    string strToInsert = data[2];

                    if (IsValid(index, inputStops.Length))
                    {
                        inputStops = inputStops.Insert(index, strToInsert);

                    }
                    Console.WriteLine(inputStops);
                }
                if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);

                    if ( IsValid(startIndex, inputStops.Length) && IsValid(endIndex, inputStops.Length))
                    {
                        inputStops = inputStops.Remove(startIndex, (endIndex - startIndex) + 1);


                    }
                    Console.WriteLine(inputStops);
                }
                if (command == "Switch")
                {
                    string oldStr = data[1];
                    string newStr = data[2];
                    
                    
                        if (inputStops.Contains(oldStr))
                        {
                            inputStops = inputStops.Replace(oldStr, newStr);
                        }
                        
                    
                   
                  
                    Console.WriteLine(inputStops);
                }

                input = Console.ReadLine();
            }
          
                Console.WriteLine($"Ready for world tour! Planned stops: {inputStops}");

            
        }
            
        private static bool IsValid(int index, int length)
        {
            return index >= 0 && index < length;
        }
    }
}
