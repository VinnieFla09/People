using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using People.Models;

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
        public SelectMonths[] Months { get; set; }
        =
        {
            new SelectMonths("Jan",false),
            new SelectMonths("Feb",false),
            new SelectMonths("Mar",false),
            new SelectMonths("Apr",false),
            new SelectMonths("May",false),
            new SelectMonths("Jun",false),
            new SelectMonths("Jul",false),
            new SelectMonths("Aug",false),
            new SelectMonths("Sept",false),
            new SelectMonths("Oct",false),
            new SelectMonths("Nov",false),
            new SelectMonths("Dec",false),
        };

        public List<SelectListItem> MonthList { get; set; } =
            new List<SelectListItem>
            {
            new SelectListItem("Jan","Jan"),
            new SelectListItem("Feb","Feb"),
            new SelectListItem("Mar","Mar"),
            new SelectListItem("Apr","Apr"),
            new SelectListItem("May","May"),
            new SelectListItem("Jun","Jun"),
            new SelectListItem("Jul","Jul"),
            new SelectListItem("Aug","Aug"),
            new SelectListItem("Sept","Sept"),
            new SelectListItem("Oct","Oct"),
            new SelectListItem("Nov","Nov"),
            new SelectListItem("Dec","Dec")
            };

        [BindProperty]
        public string[] ChosenMonths { get; set; } = { };



        public void OnGet()
        {

        }

        public void OnPost()
        {
            Posted = true;
        }
    }
}