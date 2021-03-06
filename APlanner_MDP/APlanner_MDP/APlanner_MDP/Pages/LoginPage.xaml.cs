﻿using APlanner_MDP.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APlanner_MDP.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            myLocalImage.Source = ImageSource.FromFile("aplannerimage.png");
        }
        void LoginProcess(object sender, EventArgs e)
        {
            user user = new user(Entry_Username.Text, Entry_Password.Text);
            if (user.UserAuthenticated(Entry_Username.Text, Entry_Password.Text))
            {
                DisplayAlert("Login", "Login Successful", "Okay");
                Application.Current.MainPage = new MainPage();
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Try Again");
            }
        }
    }
}
