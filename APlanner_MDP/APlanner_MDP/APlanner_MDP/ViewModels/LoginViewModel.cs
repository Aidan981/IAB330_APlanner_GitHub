using System;
using System.Collections.Generic;
using System.Text;
using APlanner_MDP.Models;
using APlanner_MDP.Pages;
using Xamarin.Forms;

namespace APlanner_MDP.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        
        public LoginViewModel()
        {
            userSecret = new user("Username", "Password");
        }
        private user userSecret;
        public Command tryToLogin{ get; private set; }
        private user UserLogin
        {
            get { return userSecret; }
            set
            {
                userSecret = value;
                OnPropertyChanged();
            }
        }
        public System.Windows.Input.ICommand ButtonPress
        {
            get {return ButtonPress; }
            set
            {
                if (userSecret.UserAuthenticated("username", "password"))
                { Application.Current.MainPage = new MainPage(); }
                else
                {
                    App.Current.MainPage.DisplayAlert("Login", "Login Failed", "Try Again");
                }
            }
        }
        
    }
}
