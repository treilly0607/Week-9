/*================================================================================
 * Tristan Reilly
 * s00199625
 * 23/11/2020
 * Week 9 Programming Practice
 ===============================================================================*/

using System;

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
        }
    }
}
