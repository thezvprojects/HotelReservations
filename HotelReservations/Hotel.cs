using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations
{
    public class Hotel
    {
        List<Room> rooms;

        public Hotel(int size)
        {
            rooms = new List<Room>(size);
            for (int i = 0; i < size; i++)
            {
                rooms.Add(new Room(i + 1));
            }
        }

        public bool makeReservations(int startDate, int endDate)
        {
            int roomNum = -1;
            bool roomAvailable = false;

            if (startDate < 0 || startDate > 365 || endDate < 0 || endDate > 365)
            {
                Console.WriteLine("Invalid values for the starting date or the ending date, both have to be between 0 and 365");
                return false;
            }

            if (startDate > endDate)
            {
                Console.WriteLine("Invalid values: ending date is before the starting date");
                return false;
            }


            foreach (Room room in rooms)
            {
                if (room.roomAvailabilityChecker(startDate, endDate))
                {
                    roomAvailable = true;
                    roomNum = room.RoomNumber;
                    break;
                }
            }

            if (!roomAvailable)
            {
                Console.WriteLine("Sorry, we have no rooms left for a reservation from day " + startDate + " to day " + endDate);
                return false;
            }

            Console.WriteLine("Successfully booked room " + roomNum + " from day " + startDate + " to day " + endDate);
            return true; ;
        }
    }
}
