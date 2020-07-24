using System;
using System.Collections.Generic;

namespace Prototype
{
    internal class Movie
    {
        public string Name { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public List<string> Ratings { get; private set; }
        public Movie(string name, DateTime releaseDate, List<string> ratings)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Ratings = ratings;
        }
        public Movie ShallowCopy() => (Movie)this.MemberwiseClone();
    }
}