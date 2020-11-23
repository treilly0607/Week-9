using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Practice
{
    public class Song:IComparable
    {

        //  Properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; } 

        //  Contructors
        public Song(string title, string artist, double duration, Genre musicGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }
        // Default Contructors if duration and genre unknown
        public Song(string title, string artist) : this(title,artist,0,Genre.Other) { }
        // Default Contructors if all unknown
        public Song() : this("Unknown", "Unknown") { }


        public override string ToString()
        {
            return string.Format($"{Title} {Artist} {Duration} {MusicGenre}");
        }

        public int CompareTo(object other)
        {
            Song that = (Song)other;

            int returnValue = this.Artist.CompareTo(that.Artist); // sort by artist

            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(that.Title); // sort by title if artist the same
            }

            return returnValue;
        }
    }
    public enum Genre // enum for genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
