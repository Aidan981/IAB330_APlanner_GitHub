using APlanner_MDP;
using APlanner_MDP.Models;
using APlanner_MDP.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner_MDP.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            allAssessments = new Assessment();
        }
        private Assessment allAssessments;

        public Assessment AllAssessments
        {
            get { return allAssessments; }
            set
            {
                allAssessments = value;
                OnPropertyChanged();
            }
        }

    }
}
