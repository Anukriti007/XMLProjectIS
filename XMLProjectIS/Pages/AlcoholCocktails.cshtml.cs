/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AlcoholCocktailData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlcoholCocktail.Pages
{
    public class AlcoholCocktailsModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string AlcoholCocktailData = webClient.DownloadString("https://www.thecocktaildb.com/api/json/v1/1/filter.php?a=Alcoholic");
                var alcoholcocktails = AlcoholCocktails.FromJson(AlcoholCocktailData);
                ViewData["AlcoholCocktails"] = alcoholcocktails;
            }
        }
    }
}
*/