using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TV;

namespace XMLProjectIS.Pages
{
    public class ItemDataModel : PageModel
    {
        public string MovieIdentifier { get; set; }
        public void OnGet()
        {


            APICall adapter = new APICall();

            var movieDetailsData = adapter.GetMovieDetails();
            
            MovieIdentifier = Request.Query["MovieIdentifier"];

            //List<MovieDetails.Item> specificMovieSearch = new List<MovieDetails.Item>();
            MovieDetails.Item[] specificMovieSearch = new MovieDetails.Item[1];
            if (!string.IsNullOrWhiteSpace(MovieIdentifier))
            {
                foreach (MovieDetails.Item searchMovie in movieDetailsData)
                {
                    string currentMovie = searchMovie.Title.ToLower();
                    if (currentMovie.Equals(MovieIdentifier.ToLower()))
                    {
                        specificMovieSearch[0] = searchMovie;

                        if (specificMovieSearch[0] != null)
                        { break; }
                    }

                }

                if (specificMovieSearch[0] == null)
                {
                    var TVDetailsData = adapter.GetTVDetails();
                    TV.Item[] specificTVSearch = new TV.Item[1];
                    foreach (TV.Item searchTV in TVDetailsData)
                    {
                        string currentTV = searchTV.Title.ToLower();
                        if (currentTV.Equals(MovieIdentifier.ToLower()))
                        {
                            specificTVSearch[0] = searchTV;
                            if (specificTVSearch[0] != null)
                            { break; }
                        }

                    }
                    TVDetailsData = specificTVSearch;
                    ViewData["TVDetails"] = TVDetailsData;
                }

                movieDetailsData = specificMovieSearch;


                /*ViewData["PlayerData"] = playerData;*/
            }
            else
            {
                ViewData["MovieDetails"] = null;


            }

            ViewData["MovieDetails"] = movieDetailsData;
            




        }
    }
}
