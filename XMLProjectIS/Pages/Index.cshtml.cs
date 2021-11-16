using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace XMLProjectIS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string movie_details = "";

                try
                {
                    movie_details = webClient.DownloadString("https://imdb-api.com/en/API/Top250Movies/k_emiixec6");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API", e);
                }

                var movieDetailsData = MovieDetails.Movies.FromJson(movie_details).Items;
                ViewData["MovieDetails"] = movieDetailsData;


            }
        }
    }
}
