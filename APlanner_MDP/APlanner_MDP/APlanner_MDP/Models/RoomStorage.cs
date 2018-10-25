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
            ObservableCollection<GroupedRooms> allRooms = new ObservableCollection<GroupedRooms>();
            GroupedRooms XBlock;
            GroupedRooms ZBlock;
            GroupedRooms HBlock;
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
            HBlock = new GroupedRooms()
            {
                new Room("H340", "You can learn here", true, true, true),
                new Room("H123", "Good View", true, true, true),
                new Room("H520", "Good for Group-work", true, true, true),
                new Room("H120", "Water Fountain inside", true, true, true)
            };
            XBlock.Block = "X Block";
            ZBlock.Block = "Z Block";
            HBlock.Block = "H Block";
            allRooms.Add (XBlock);
            allRooms.Add (ZBlock);
            allRooms.Add (HBlock);
            return (allRooms);
        }
    }
}
