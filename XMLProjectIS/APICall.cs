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
            string moviesURL = "https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/Top250Movies.json";
            var movieDetailsStr = CallApiFunction(moviesURL);
            //parse the json string 
            MovieDetails.Item[] result = MovieDetails.Movies.FromJson(movieDetailsStr).Items;
            return result;

        }

        public TV.Item[] GetTVDetails()
        {
            string TVURL = "https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/Top250TVShows.json";
            var TVDetailStr = CallApiFunction(TVURL);
            //parse the json string 
            TV.Item[] result = TV.TVDetails.FromJson(TVDetailStr).Items;
            return result;
        }
    }
}
