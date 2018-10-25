using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace APlanner_MDP.Models
{
    public static class RoomSearch
    {
        public static ObservableCollection<GroupedRooms> searchRightRooms(ObservableCollection<GroupedRooms> allRooms, bool outside, bool powerplugs, bool eatanddrink)
        {
            ObservableCollection<GroupedRooms> searchedRooms = new ObservableCollection<GroupedRooms>();
            searchedRooms = allRooms;
            for (int i = 0; i < allRooms.Count; i++)
            {
                //int numberDeleted = 0;
                GroupedRooms roomGroup = allRooms[i];
                for (int k = 0; k < roomGroup.Count; k++)
                {
                    if (roomGroup.Count == 0)
                    {
                        break;
                    }
                    Room singleRoom = roomGroup[k];
                   if ((outside && !singleRoom.Outside) || (powerplugs && !singleRoom.Powerplugs) || (eatanddrink && !singleRoom.Eatanddrink))
                    {
                        searchedRooms[i].Rooms.RemoveAt(k);
                        //numberDeleted = numberDeleted + 1;
                        k = k - 1;
                    }
                }
            }
            return searchedRooms;
        }
    }
}
