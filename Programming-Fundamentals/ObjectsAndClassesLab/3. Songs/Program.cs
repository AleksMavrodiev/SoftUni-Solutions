using System;
using System.Collections.Generic;

namespace _3._Songs
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            int songCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < songCount; i++)
            {
                string input = Console.ReadLine();
                string[] cmdArgs = input.Split('_', StringSplitOptions.RemoveEmptyEntries);
                string typeList = cmdArgs[0];
                string somgName = cmdArgs[1];
                string somgTime = cmdArgs[2];
                Song newSong = new Song(typeList, somgName, somgTime);
                songs.Add(newSong);
            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = new List<Song>();
                filteredSongs = songs.FindAll(x => x.TypeList == command);
                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
