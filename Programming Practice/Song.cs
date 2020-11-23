using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Practice
{
    public class Song
    {

        //properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; } 



    }
    public enum Genre // enum for genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
}
