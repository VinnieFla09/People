using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace People.pages
{
    public class WS1bModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }
        [BindProperty]
        public int Number2 { get; set; }
        [BindProperty]
        public int Number3 { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = string.Format("Your numbers entered were {0}, {1} and {2} Total = {3}", Number1, Number2, Number3, Number1+Number2+Number3);
        }
    }
}