using System;
using System.Collections.Generic;

namespace _03.Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatList = new List<string>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] data = input.Split();

                string command = data[0];

                if (command == "Chat")
                {
                  
                        chatList.Add(data[1]);
                   

                }
                else if (command == "Delete")
                {
                    if (chatList.Contains(data[1]))
                    {
                        chatList.Remove(data[1]);
                    }
                }
                else if (command == "Edit")
                {
                    if (chatList.Contains(data[1]))
                    {
                        int index = 0;
                        for (int i = 0; i < chatList.Count; i++)
                        {
                            if (chatList[i] == data[1])
                            {
                                index = i;
                            }
                        }

                        chatList.Remove(data[1]);
                        chatList.Insert(index, data[2]);


                    }

                }
                else if (command == "Pin")
                {
                    if (chatList.Contains(data[1]))
                    {
                        chatList.Remove(data[1]);
                        chatList.Add(data[1]);


                    }
                }
                else if (command == "Spam")
                {
                    for (int i = 1; i < data.Length; i++)
                    {
                        chatList.Add(data[i]);
                    }
                }

            }

            Console.WriteLine(string.Join("\n", chatList));

        }
    }
}
