using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace People.pages
{
    public class greetingModel : PageModel
    {
        public string Message { get; set; } = "Hello there";

        public void OnGet()
        {
          if (DateTime.Now.Hour >= 12)
            {
                Message = "good afternoon!!";
            }

          else
            {
                Message = "good morning";
            }

        }
    }
}