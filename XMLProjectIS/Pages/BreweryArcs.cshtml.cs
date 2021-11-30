using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BreweryArcData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreweryArcsPage.Pages
{
    public class BreweryArcsModel : PageModel
    {
        public void OnGet()
        {
            using(var webclient = new WebClient())
            {
                string breweryAData = webclient.DownloadString("https://api.openbrewerydb.org/breweries");
                var breweryarcs = BreweryArcs.FromJson(breweryAData);
                ViewData["BreweryArcs"] = breweryarcs;
            }
            

        }
    }
}
