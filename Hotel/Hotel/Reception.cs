using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public static class Reception 
    {
        private const int numberOfRooms = 100;
        private static int numberOfGuests = 0;
        private static Room[] rooms = new Room[numberOfRooms];
        public static void SetRooms()
        {
            for (int i = 0; i < numberOfRooms; i++)
            {
                if (i < 33)
                    rooms[i] = new RoomForTwo(i, 50);
                else if (i < 66)
                    rooms[i] = new FamilyRoom(i, 50);
                else
                    rooms[i] = new Suite(i, 50);
            }
        }
        public static Room CheckIn(Guest guest)
        {
            for (int i = 0; i < numberOfRooms; i++)
            {
                if (IsRoomFree(rooms[i]))
                {
                    rooms[i].SetGuest(guest);
                    numberOfGuests++;
                    return rooms[i];
                }
            }
            return null;
        }
        public static void CheckOut (Room room)
        {
            rooms[room.RoomNumber] = null;
            room.SetRoomNumber(0);
            numberOfGuests--;
        }
        public static bool IsRoomFree (Room room)
        {
            return room.Guest == null;
        }
        public static void SendRoomService (Room room)
        {
            string[] features = room.Features.Split(',');
            switch (features.Length)
            {
                case 2:
                    RoomService.CleanRoom((RoomForTwo)room);
                    break;
                case 4:
                    RoomService.CleanRoom((FamilyRoom)room);
                    break;
                case 5:
                    RoomService.CleanRoom((Suite)room);
                    break;
            }          
        }
    }
}
