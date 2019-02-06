using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This class holds the name of the month and if it is selected
namespace People.Models
{
    public class SelectMonths
    {
        public string MonthName { get; set; }
        public bool IsSelected { get; set; }

        public SelectMonths(string monthName, bool isSelected)
        {
            MonthName = monthName;
            IsSelected = isSelected;
        }

        public SelectMonths()
        {
            MonthName = "";
            IsSelected = false;
        }
    }
}
