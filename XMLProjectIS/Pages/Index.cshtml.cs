using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using QuickType;
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
                string jsonString = webClient.DownloadString("https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/csvjson(2).json");
                var welcome = Welcome.FromJson(jsonString);
                ViewData["Welcome"] = welcome;
                string jsonString1 = webClient.DownloadString("https://raw.githubusercontent.com/Anukriti007/XMLProjectIS/master/csvjson(1).json");
                var welcome1 = Welcome.FromJson(jsonString1);
                ViewData["Welcome1"] = welcome1;
            }
        }
    }
}

