using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
                string jsonString = webClient.DownloadString("https://raw.githubusercontent.com/prust/wikipedia-movie-data/master/movies.json");
                string result = "";

                try
                {
                    result = webClient.DownloadString(jsonString);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API", e);



                }
                var movieList = Movies.MovieCollection.FromJson(jsonString);
                ViewData["Movie_List"] = movieList;
            }
        }
    }
}
