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
            AllRooms = RoomStorage.GetRooms("username", "password");
        }
    }
}
