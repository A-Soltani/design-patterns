using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call movie service to fetch movie info
            Movie movie = new MovieService().GetMovie("Avengers");
            Console.WriteLine("Calling this service costs 0.1 $ (this is just an example)");

            Console.WriteLine("******** original movie info ********");
            PrintMovieInfo(movie);

            // To avoid another service call, cloning is used
            Movie clonedMovie = movie.ShallowCopy();

            // Adding another rating in our application
            clonedMovie.Ratings.Add("Common Sense Media: 4/5");

            Console.WriteLine($"{Environment.NewLine} ******** the movie info after changing in our application ********");
            PrintMovieInfo(clonedMovie);

            Console.ReadKey();
        }

        private static void PrintMovieInfo(Movie movie)
        {
            Console.WriteLine($"Name: {movie.Name} {Environment.NewLine}" +
                              $"Release Date: {movie.ReleaseDate.ToShortDateString()} {Environment.NewLine}");
            
            Console.WriteLine("movie ratings:");
            movie.Ratings.ForEach(Console.WriteLine);
        }
    }
}
