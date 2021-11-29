using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XMLProjectIS.Pages
{
    public class Movies_detailModel : PageModel
    {
        public void OnGet()
        {
            APICall adapter = new APICall();

            var movieDetailsData = adapter.GetMovieDetails(); 
            ViewData["MovieDetails"] = movieDetailsData;
            
        }

        
    }
}
