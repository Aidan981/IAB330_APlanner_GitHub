using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace APlanner_MDP.Models
{
    public static class RoomStorage
    {


        public static ObservableCollection<GroupedRooms> GetRooms(string username, string password)
        {
            ObservableCollection<Room> firstBuilding = new ObservableCollection<Room>();
            ObservableCollection<Room> secoundBuilding = new ObservableCollection<Room>();
            ObservableCollection<GroupedRooms> allRooms = new ObservableCollection<GroupedRooms>();
            GroupedRooms XBlock;
            GroupedRooms ZBlock;
            XBlock = new GroupedRooms()
            {
                new Room("X340", "You can learn here", true, true, true),
                new Room("X123", "Good View", true, true, true),
                new Room("X520", "Good for Group-work", true, true, true),
                new Room("X120", "Water Fountain inside", true, true, true)
            };
            ZBlock = new GroupedRooms()
            {
                new Room("Z142", "You can learn here", false, false, true),
                new Room("Z351", "You can learn here", true, false, true)
            };
            XBlock.Block = "X Block";
            ZBlock.Block = "Z Block";
            allRooms.Add (XBlock);
            allRooms.Add (ZBlock);
            return (allRooms);
        }
    }
}
