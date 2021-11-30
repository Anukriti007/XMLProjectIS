using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XMLProjectIS.Pages
{
    public class Top250MoviesModel : PageModel
    {
        public JsonResult OnGet()
        {
            using (var webClient = new WebClient())
            {

                APICall adapter = new APICall();

                var movieDetailsData = adapter.GetMovieDetails();
                return new JsonResult(movieDetailsData);
            }
        }
    }
}
