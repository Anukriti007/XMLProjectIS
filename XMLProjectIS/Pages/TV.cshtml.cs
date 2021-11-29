using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XMLProjectIS.Pages
{
    public class TVModel : PageModel
    {
        public void OnGet()
        {
            APICall adapter = new APICall();

            var TVDetailsData = adapter.GetTVDetails();
            ViewData["TvDetails"] = TVDetailsData;
            
        }
    }
}
