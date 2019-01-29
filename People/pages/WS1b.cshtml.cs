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

        [BindProperty]
        public string Button { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Button == "Add")
            {
                Message = string.Format("Your numbers entered were {0}, {1} and {2}  and function is add. Total = {3}", Number1, Number2, Number3, Number1 + Number2 + Number3);
            }

            else if (Button == "Subtract")
            {
                Message = string.Format("Your numbers entered were {0}, {1} and {2} and function is subtract. Total = {3}", Number1, Number2, Number3, Number1 - Number2 - Number3);
            }

            else if (Button == "Multiply")

            {
                Message = string.Format("Your numbers entered were {0}, {1} and {2}  and function is multiply.  Total = {3}", Number1, Number2, Number3, Number1 * Number2 * Number3);
            }

            else if (Button == "Divide")

            {
                Message = string.Format("Your numbers entered were {0}, {1} and {2} and function is divide. Total = {3}", Number1, Number2, Number3, Number1 / Number2 / Number3);
            }

            else
                Message = string.Format("Your numbers entered were {0}, {1} and {2}. No function selected to perform", Number1, Number2, Number3, Number1 / Number2 / Number3);

        }
    }
}