using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= numSongs ; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }
            string typeListOrAll = Console.ReadLine();

            if (typeListOrAll == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (typeListOrAll == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
