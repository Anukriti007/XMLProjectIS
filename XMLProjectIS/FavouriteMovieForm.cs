using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XMLProjectIS
{
    public class FavouriteMovieForm
    {
        static FavouriteMovieForm()
        {
            allMovies = new List<Movie>();
        }

        public static IList<Movie> allMovies { get; set; }
    }
}

