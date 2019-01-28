using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace People.pages
{
    public class W2ws1Model : PageModel
    {
        public string[] myArray { get; set; } = { "Ireland", "England", "France", "Wales", "Scotland", "Italy" };

        public string Message { get; set; }
        public void OnGet()
        {
            

        }

        public void OnPost(string Input1)
        {           
            Message = string.Format("Hello {0}", Input1);
        }
    }
}