using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APlanner_MDP.ViewModels;
using APlanner_MDP.Models;
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