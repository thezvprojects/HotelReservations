using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Room
    {
        SortedSet<int> daysOccupied;
        int roomNumber;

        public Room(int num)
        {
            roomNumber = num;
            daysOccupied = new SortedSet<int>();
        }

        public int RoomNumber { get { return roomNumber; } }

        public bool roomAvailabilityChecker(int startDate, int endDate)
        {
            for (int i = startDate; i <= endDate; i++)
                if (daysOccupied.Contains(i)) return false;
            for (int i = startDate; i <= endDate; i++)
                daysOccupied.Add(i);
            return true;
        }
    }
}
