using System;
using System.Collections.Generic;
using System.Text;

namespace NewFavoriteStuff.NESGames
{
    abstract class NESGame
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public NESGame(string name, string genre, int year)
        {
            Name = name;
            Genre = genre;
            Year = year;
        }
    }
}