using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace XMLProjectIS.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]

        public string MovieIdentifier { get; set; }
        public SelectList MovieList { get; set; }
        public string SearchMovie { get; set; }


        public void OnGet()
        {

        }

    }
}






