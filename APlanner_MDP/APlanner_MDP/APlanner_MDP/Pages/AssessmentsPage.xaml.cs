using APlanner_MDP.Models;
using APlanner_MDP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlanner_MDP.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentsPage : ContentPage
    {
        public AssessmentsPage()
        {
            BindingContext = new AssessmentViewModel();
            InitializeComponent();
        }
    }
}