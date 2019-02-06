using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace People.pages
{
    public class TimeModel : PageModel
    {
//Task 1
        public string[] DaysOfWeek { get; set; }
        = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [BindProperty]
        public bool[] DaysSelected { get; set; }
        = { false, false, false, false, false, false, false };

        [BindProperty]
        public string[] DaysToPrint { get; set; }

        public bool Posted { get; set; } = false;

        //Task2 
        //Create an object of the SelectMonth Class for each month (not chosen by default)
        [BindProperty]

        

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Posted = true;
        }
    }
}