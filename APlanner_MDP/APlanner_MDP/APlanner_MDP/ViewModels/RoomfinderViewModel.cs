using System;
using System.Collections.Generic;
using System.Text;
using APlanner_MDP.Pages;
using APlanner_MDP.Models;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace APlanner_MDP.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class RoomfinderViewModel : ViewModelBase
    {
        private ObservableCollection<GroupedRooms> allRooms;
        
        public ObservableCollection<GroupedRooms> AllRooms
        {
            get { return allRooms; }
            set { allRooms = value;
                OnPropertyChanged(); }
        }
        public RoomfinderViewModel()
        {
            allRooms = RoomStorage.GetRooms("username", "password");
        }
        private bool outsidetoggle = false;
        private bool powerplugstoggle = false;
        private bool eatanddrinktoggle = false;
        public bool OutsideToggle
        {
            get {return outsidetoggle; }
            set {
                outsidetoggle = value;
                allRooms = RoomSearch.searchRightRooms(RoomStorage.GetRooms("username", "password"), outsidetoggle, powerplugstoggle, eatanddrinktoggle);
                OnPropertyChanged("AllRooms");
            }
        }
        public bool PowerpluginToggle
        {
            get { return powerplugstoggle; }
            set
            {
                powerplugstoggle = value;
                allRooms = RoomSearch.searchRightRooms(RoomStorage.GetRooms("username", "password"), outsidetoggle, powerplugstoggle, eatanddrinktoggle);
                OnPropertyChanged("AllRooms");
            }
        }
        public bool EatanddrinkToggle
        {
            get { return eatanddrinktoggle; }
            set
            {
                eatanddrinktoggle = value;
                allRooms = RoomSearch.searchRightRooms(RoomStorage.GetRooms("username", "password"), outsidetoggle, powerplugstoggle, eatanddrinktoggle);
                OnPropertyChanged("AllRooms");
            }
        }
    }
}
