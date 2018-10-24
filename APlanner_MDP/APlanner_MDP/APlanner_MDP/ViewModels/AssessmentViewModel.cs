using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APlanner_MDP.ViewModels;
using APlanner_MDP.Models;
using APlanner_MDP.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace APlanner_MDP.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class AssessmentViewModel : ViewModelBase
    {
        public ObservableCollection<Assessment> Assessments
        {
            get { return assessments; }
            set {; }
        }
        private ObservableCollection<Assessment> assessments;
        public AssessmentViewModel()
        {
            assessments = AssessmentStorage.getAssessments("username","password");
        }
    }
}
