using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XMLProjectIS.Pages
{
    public class DetailsModel : PageModel
    {
        public void OnGet()
        {


            APICall adapter = new APICall();
            var movieDetailsData = adapter.GetMovieDetails();
            var TVDetailsData = adapter.GetTVDetails();

            string selectedMovieID = Request.Query["id"];
            MovieDetails.Item[] selectedMovie = new MovieDetails.Item[1];

            foreach (MovieDetails.Item movie in movieDetailsData)
            {

                string currentMovieID = movie.Id;
                if (currentMovieID.Equals(selectedMovieID))
                {
                    selectedMovie[0] = movie;
                }
            }
            //Console.WriteLine("plcc", pColl);

            ViewData["SelectedMovieDetails"] = selectedMovie[0];

            string selectedTVID = Request.Query["id"];
            TV.Item[] selectedTV = new TV.Item[1];

            foreach (TV.Item TV in TVDetailsData)
            {

                string currentTVID = TV.Id;
                if (currentTVID.Equals(selectedTVID))
                {
                    selectedTV[0] = TV;
                }
            }
            //Console.WriteLine("plcc", pColl);

            ViewData["SelectedTVDetails"] = selectedTV[0];

        }
    }
}
