using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner.Models
{
    public class Assessment
    {
        public Assessment()
        {
            Name = "Assesment 1";
            Unit = "IAB330";
            description = "Write a text.";
            link = "www.google.com";
            duedate = new DateTime(2018,12,2);
        }
        public string Name { get; set; }
        public string Unit { get; set; }
        public DateTime duedate;
        public string description;
        public string link;
    }
}
