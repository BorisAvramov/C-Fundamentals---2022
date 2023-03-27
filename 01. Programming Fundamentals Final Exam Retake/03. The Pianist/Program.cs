using System;
using System.Collections.Generic;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> pieceComposerKey = new Dictionary<string, string[]>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("|");
                pieceComposerKey.Add(data[0], new string[2]);
                pieceComposerKey[data[0]][0] = data[1]; 
                pieceComposerKey[data[0]][1] = data[2]; 

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                string[] data = input.Split("|");
                string command = data[0];
                string piece = data[1];

                if (command == "Add")
                {
                    string composer = data[2];
                    string key = data[3];
                    if (pieceComposerKey.ContainsKey(piece) == false)
                    {
                        pieceComposerKey.Add(piece, new string[2]);
                        pieceComposerKey[piece][0] = composer;
                        pieceComposerKey[piece][1] = key;
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }

                }
                if (command == "Remove")
                {
                    if (pieceComposerKey.ContainsKey(piece))
                    {

                        pieceComposerKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");

                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }


                }
                if (command == "ChangeKey")
                {
                    string newKey = data[2];
                    if (pieceComposerKey.ContainsKey(piece))
                    {
                        pieceComposerKey[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }


            }
            foreach (var item in pieceComposerKey)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}"); 

            }


        }
    }
}
