using APlanner_MDP.Models;
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
        public LoginPage()
        {
            InitializeComponent();
        }
        void LoginProcess(object sender, EventArgs e)
        {
            user user = new user(Entry_Username.Text, Entry_Password.Text);

            if (user.UserAuthenticated())
            {
                DisplayAlert("Login", "Login Successful", "Okay");

            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Try Again");
            }
        }


    }
}
