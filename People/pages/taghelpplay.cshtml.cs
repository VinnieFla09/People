using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace People.pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        public void OnGet()
        {

        }
    }
}