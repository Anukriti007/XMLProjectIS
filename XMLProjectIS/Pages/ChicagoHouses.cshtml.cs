using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ChicagoHousesData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChicagoHousePage.Pages
{
    public class ChicagoHousesModel : PageModel
    {
        public void OnGet()
        {

               using(var webClient = new WebClient())
            {
                string chicagoHData = webClient.DownloadString("https://realestate20211125150037.azurewebsites.net/HousingRaw");
                var chicagohouses = ChicagoHouses.FromJson(chicagoHData);
                ViewData["ChicagoHouses"] = chicagohouses;
            }
               
        }
    }
}
