using APlanner;
using APlanner.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APlanner.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            AllAssessments = new Assessment();
        }
        //private string assesment1 = "Kein Assesment gefunden!";
        private Assessment allAssessments;

        public Assessment AllAssessments
        {
            get { return allAssessments; }
            set {
                allAssessments = value;
                OnPropertyChanged();
            }
        }

    }
}
