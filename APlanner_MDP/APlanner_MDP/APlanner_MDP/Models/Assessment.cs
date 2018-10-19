using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner_MDP.Models
{
    public class Assessment
    {
        public Assessment()
        {
            Name = "Assessment 1";
            Unit = "IAB330";
            Description = "Write a text.";
            Link = "www.google.com";
            Duedate = new DateTime(2018, 12, 2);
        }
        public string Name { get; set; }
        public string Unit { get; set; }
        public DateTime Duedate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
