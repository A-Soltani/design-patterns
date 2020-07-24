using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype
{
    internal class MovieService
    {
        private readonly List<Movie> _movies;

        public MovieService()
        {
            _movies = new List<Movie>()
            {
                new Movie("Avengers", new DateTime(2019,11,22),
                    new List<string>()
                    {
                        "Rotten Tomatoes: 94%",
                        "IMDb: 8.4/10"
                    }),
                new Movie("Toy Story 4", new DateTime(2019,6,11),
                    new List<string>()
                    {
                        "Rotten Tomatoes: 97%",
                        "IMDb: 7.8/10"
                    })

            };
        }
        public Movie GetMovie(string name) => _movies.Single(m => m.Name == name);
    }
}