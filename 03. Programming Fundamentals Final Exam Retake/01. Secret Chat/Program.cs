using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string massage = Console.ReadLine();
        
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Reveal")
                {
                    break;
                }

                string[] data = input.Split(":|:");
                string command = data[0];

                if (command == "InsertSpace")
                {
                    massage = massage.Insert(int.Parse(data[1]), " ");
                    Console.WriteLine(massage);
                }
                if (command == "Reverse")
                {
                    string substring = data[1];
                    string reversedString = "";

                    for (int i = substring.Length - 1; i >= 0; i--)
                    {
                        reversedString += substring[i];
                    }
                       
                   
                    if (massage.Contains(substring))
                    {
                        massage =  massage.Remove(massage.IndexOf(substring),substring.Length);
                        foreach (var item in reversedString)
                        {
                            massage += item;
                        }

                        Console.WriteLine(massage);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
               
                }
                if (command == "ChangeAll")
                {
                    while (massage.Contains(data[1]))
                    {

                        massage = massage.Replace(data[1], data[2]);


                    }
                    Console.WriteLine(massage);
                }
            }

            Console.WriteLine($"You have a new text message: {massage}");
        }
    }
}
