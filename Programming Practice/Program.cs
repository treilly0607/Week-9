﻿/*================================================================================
 * Tristan Reilly
 * s00199625
 * 23/11/2020
 * Week 9 Programming Practice
 ===============================================================================*/

using System;
using System.Collections.Generic;

namespace Programming_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Song Objects
            Song s1 = new Song("BEUTIFUL PEOPLE","ED SHEERIN", 3.15, Genre.Pop);
            Song s2 = new Song("DANCE MONKEY", "TONES AND I", 4.20, Genre.Dance);
            Song s3 = new Song("CIRCLES", "POST MALONE", 3.25, Genre.Pop);
            Song s4 = new Song("RIDE IT", "REGARD", 3.37, Genre.Dance);
            Song s5 = new Song("SOUTH OF THE BORDER", "ED SHEERIN", 4.26, Genre.Pop);

            // Add Song Objects To List playlist
            List<Song> playlist = new List<Song>();
            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);

            Display(playlist);
            playlist.Sort();
            Console.WriteLine();
            Display(playlist);
            Shuffle(playlist);
            Console.WriteLine();
            Display(playlist);
        }

        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("{0, -20}{1,-25}{2, -10}{3, -10}","Artist","Song","Duration","Genre"); // header

            // Display Songs in playlist List
            foreach (Song song in playlist)
            {
                Console.WriteLine($"{song.Artist, -20}{song.Title, -25}{song.Duration, -10}{song.MusicGenre, -10}");
            }
        }

        private static void Shuffle(List<Song> playlist)
        {
            Random r = new Random();
            int numberOfSong = playlist.Count;

            while (numberOfSong > 1)
            {
                numberOfSong--;
                int randomNumber = r.Next(numberOfSong + 1);
                Song song = playlist[randomNumber];
                playlist[randomNumber] = playlist[numberOfSong];
                playlist[numberOfSong] = song;
            }
        }
    }
}
