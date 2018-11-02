using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using APlanner_MDP.Pages;
using APlanner_MDP.Models;
using System.Text;

namespace APlanner_MDP.Data
{
    public static class AssessmentStorage
    {
        public static ObservableCollection<Assessment> getAssessments(string username, string password)
        {
            return (new ObservableCollection<Assessment> {
                new Assessment("Assessment 1","IAB330", new DateTime(2018,10,09,23,59,59),"You have to write a text.","www.google.com"),
                new Assessment("Final Exam","CAB340", new DateTime(2018,10,18,10,30,0),"You have to write a text.","www.google.com"),
                new Assessment("Assessment 3","CAB230", new DateTime(2018,11,01,10,0,0),"You have to write a text.","www.google.com"),
                new Assessment("Assessment 4","EGB339", new DateTime(2018,11,01,23,59,59),"You have to write a text.","www.google.com")
            });
        }
    }
}
