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
            GroupedRooms FBlock;
            GroupedRooms Garden;
            XBlock = new GroupedRooms()
            {
                new Room("X340", "You can learn here", false, false, true),
                new Room("X123", "Good View", false, false, true),
                new Room("X520", "Good for Group-work", false, false, false),
                new Room("X120", "Water Fountain inside", false, true, true)
            };
            ZBlock = new GroupedRooms()
            {
                new Room("Z142", "You can learn here", false, false, true),
                new Room("Z351", "You can learn here", false, false, true)
            };
            HBlock = new GroupedRooms()
            {
                new Room("H340", "You can learn here", false, true, true),
                new Room("H123", "Good View", false, true, true),
                new Room("H520", "Good for Group-work", false, true, true),
                new Room("H120", "Water Fountain inside", false, true, true)
            };
            FBlock = new GroupedRooms()
            {
                new Room("F340", "You can learn here", false, true, true),
                new Room("F120", "You can learn here", false, false, true),
                new Room("F412", "You can learn here", false, false, false),
                new Room("F119", "You can learn here", false, true, true)
            };
            Garden = new GroupedRooms()
            {
                new Room("next to X Block", "You can learn here", true, false, true),
            };
            XBlock.Block = "X Block";
            ZBlock.Block = "Z Block";
            HBlock.Block = "H Block";
            FBlock.Block = "F Block";
            Garden.Block = "Botanical Gardens";
            allRooms.Add (XBlock);
            allRooms.Add (ZBlock);
            allRooms.Add (HBlock);
            allRooms.Add (FBlock);
            allRooms.Add (Garden); 
            return (allRooms);
        }
    }
}
