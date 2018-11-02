using System.Collections.ObjectModel;
using APlanner_MDP.Models;
using APlanner_MDP.Data;
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
