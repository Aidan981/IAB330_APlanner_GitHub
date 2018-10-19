using System;
using System.Collections.Generic;
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
	public partial class Assessments : ContentPage
	{
		public Assessments ()
		{
            BindingContext = new MainViewModel();
            InitializeComponent ();
		}
	}
}