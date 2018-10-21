using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlanner_MDP.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{

        private string _username;
        private string _password;
        private bool _areCredentialsInvalid;


        private bool UserAuthenticated(string username, string password)
        {
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return username.ToLowerInvariant() == "joe"
                && password.ToLowerInvariant() == "secret";
        }

        public LoginPage ()
		{
			InitializeComponent ();

        }


    }
}