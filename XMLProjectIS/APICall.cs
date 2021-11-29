using MovieDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace XMLProjectIS
{
    public class APICall
    {
        public APICall()
        {
        }

        private string CallApiFunction(string url)
        {
            using (var webClient = new WebClient())
            {

                String result = "";
                try
                {
                    result = webClient.DownloadString(url);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API", e);

                }
                return result;
            }
        }

        public MovieDetails.Item[] GetMovieDetails()
        {
            string moviesURL = "https://imdb-api.com/en/API/Top250Movies/k_emiixec6";
            var movieDetailsStr = CallApiFunction(moviesURL);
            //parse the json string 
            MovieDetails.Item[] result = MovieDetails.Movies.FromJson(movieDetailsStr).Items;
            return result;

        }

        public TV.Item[] GetTVDetails()
        {
            string TVURL = "https://imdb-api.com/en/API/Top250TVs/k_emiixec6";
            var TVDetailStr = CallApiFunction(TVURL);
            //parse the json string 
            TV.Item[] result = TV.TVDetails.FromJson(TVDetailStr).Items;
            return result;
        }
    }
}
