using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace APlanner_MDP.Models
{
    public class Room
    {
        public Room()
        {
        }
        public Room(string roomnumber, string description, bool outside, bool powerplugs, bool eatanddrink)
        {
            Roomnumber = roomnumber;
            Description = description;
            Outside = outside;
            Powerplugs = powerplugs;
            Eatanddrink = eatanddrink;
        }
        public string Roomnumber { get; set; }
        public string Description { get; set; }
        public bool Outside { get; set; }
        public bool Powerplugs { get; set; }
        public bool Eatanddrink { get; set; }
    }
    public class GroupedRooms : ObservableCollection<Room>
    {
        public ObservableCollection<Room> Rooms => this;
        public string Block { get; set; }
    }
}
