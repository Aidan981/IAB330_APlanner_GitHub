using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner_MDP.Models
{
    public class Assessment
    {
        public Assessment()
        {
        }
        public Assessment(string name, string unit, DateTime duedate, string description, string link)
        {
            Name = name;
            Link = link;
            Unit = unit;
            Duedate = duedate;
            Description = description;
        }
        public string Name { get; set; }
        public string Unit { get; set; }
        public DateTime Duedate { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
