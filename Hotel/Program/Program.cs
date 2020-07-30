using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;
using Hotel;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Reception.SetRooms();
            Guest guest = new Guest();
            guest.Id = 1;
            guest.Name = "Roey";
            Room room = Reception.CheckIn(guest);
            room = (RoomForTwo)room;
            if (Reception.CheckIn(guest) != null)
                Console.WriteLine("Your room number is " + room.RoomNumber + 1);
            else
                Console.WriteLine("Sorry, all the rooms are taken");
            Reception.SendRoomService(room);
            Reception.CheckOut(room);
        }
    }
}
