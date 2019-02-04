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

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double DoubleNumber { get; set; }

        [BindProperty]
        public double? DoubleNull { get; set; }

        [BindProperty]
        public decimal DecimalNumber { get; set; }

        [BindProperty]
        public decimal? DecimalNull { get; set; }

        [BindProperty]
        public float? FloatNull { get; set; }

        [BindProperty]
        public float FloatNumber { get; set; }

        [BindProperty]
        public string Stringprop { get; set; }

        [BindProperty]
        public DateTime DateAndTime { get; set; }

        [BindProperty]
        public DateTime? DateAndTimeNull { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        [BindProperty]
        public string Button { get; set; }

        public string Message { get; set; }






        public void OnGet()
        {
           
        }

        public void OnPost()
        {
            if (Season == "Spring")
            {
                Message = "It is spring!";
            }

            else if (Season == "Summer")
            {
                Message = "It is summer!";
            }

            else if (Season == "Autumn")
            {
                Message = "It is autumn!";
            }

            else if (Season == "Winter")
            {
                Message = "It is winter!";
            }

            else
                Message = "Unknown input";
        }
    }
}