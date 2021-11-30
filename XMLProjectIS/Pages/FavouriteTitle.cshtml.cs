using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XMLProjectIS.Pages
{
    public class FavouriteTitleModel : PageModel
    {
        [BindProperty]
        public Movie movie { get; set; }

        public void OnGet()
        {
            ViewData["MovieList"] = FavouriteMovieForm.allMovies;
        }

        public void OnPost()
        {
            // update the local map. 
            //string stuff = Movie.FirstName + Movie.LastName + Movie.Age + Movie.MovieName + Movie.TVShow;
            FavouriteMovieForm.allMovies.Add(movie);

            ViewData["MovieList"] = FavouriteMovieForm.allMovies;
        }
    }

}
