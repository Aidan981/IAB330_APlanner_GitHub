using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APlanner_MDP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlanner_MDP.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Roomfinder : ContentPage
	{
		public Roomfinder ()
		{
            BindingContext = new RoomfinderViewModel();
			InitializeComponent ();
		}
	}
}