using APlanner_MDP.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APlanner_MDP.Data;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace APlanner_MDP
{
    

    public partial class App : Application
    {

        //static UserDatabase UserDatabase;
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        /*
        public static UserDatabase userDb
        {
            get
            {
                if (UserDatabase == null)
                {
                    UserDatabase = new UserDatabase();
                }
                return UserDatabase;
            }
        }
        */

    }
}
