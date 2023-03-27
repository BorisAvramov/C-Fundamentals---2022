using System;
using System.Collections.Generic;

namespace _03._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Dictionary<string, Messages> dict = new Dictionary<string, Messages>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;

                }
                string[] data = input.Split("=");

                string command = data[0];
                if (command == "Add")
                {
                    string userName = data[1];
                    int sent = int.Parse(data[2]);
                    int recieved = int.Parse(data[3]);
                    if (!dict.ContainsKey(userName))
                    {
                        dict.Add(userName, new Messages(sent, recieved));
                    }
                    else
                    {
                        continue;
                    }


                }
                if (command == "Message")
                {
                    string sender = data[1];
                    string reciever = data[2];
                    if (dict.ContainsKey(sender) && dict.ContainsKey(reciever))
                    {
                        dict[sender].Sent++;
                        dict[reciever].Recieved++;

                        if ((dict[sender].Sent + dict[sender].Recieved) >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            dict.Remove(sender);
                        }
                        if ((dict[reciever].Sent + dict[reciever].Recieved) >= capacity)
                        {
                            Console.WriteLine($"{reciever} reached the capacity!");
                            dict.Remove(reciever);
                        }
                    } 

                }
                if (command == "Empty")
                {
                    string userName = data[1];
                    if (userName == "All")
                    {
                        dict.Clear();

                    }
                    else
                    {
                        dict.Remove(userName);
                    }


                }


            }

            Console.WriteLine($"Users count: {dict.Count}");
            foreach (var item in dict)
            {
                int numMessages = item.Value.Sent + item.Value.Recieved;
                Console.WriteLine($"{item.Key} - {numMessages}");


            }

        }
    }


    class Messages
    {
        public Messages(int sent, int recieved)
        {
            Sent = sent;
            Recieved = recieved;

        }

        public int Sent { get; set; }
        public int Recieved { get; set; }
    }
}
