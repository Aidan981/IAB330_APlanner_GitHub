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
        public ObservableCollection<Assessment> Assessments { get; set; }
        public AssessmentsPage()
        {
            InitializeComponent();
            Assessments = new ObservableCollection<Assessment>
            {
                new Assessment("Assessment 1","IAB330", new DateTime(2018,12,12),"You have to write a text.","www.google.com"),
                new Assessment("Assessment 2","CAB340", new DateTime(2018,12,12),"You have to write a text.","www.google.com"),
                new Assessment("Assessment 3","EGB339", new DateTime(2018,12,12),"You have to write a text.","www.google.com")
            };

            AssessmentListView.ItemsSource = Assessments;
        }
    }
}