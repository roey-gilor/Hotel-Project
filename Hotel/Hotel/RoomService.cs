using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal static class RoomService
    {
        internal static void CleanRoom(RoomForTwo room)
        {
            string[] features = room.Features.Split(',');
            foreach (var item in features)
            {
                Console.WriteLine(item+" is clean");
            }
            room.IsClean = true;
        }
        internal static void CleanRoom(FamilyRoom room)
        {
            string[] features = room.Features.Split(',');
            foreach (var item in features)
            {
                Console.WriteLine(item + " is clean");
            }
            room.IsClean = true;
        }
        internal static void CleanRoom(Suite room)
        {
            string[] features = room.Features.Split(',');
            foreach (var item in features)
            {
                Console.WriteLine(item + " is clean");
            }
            room.IsClean = true;
        }
    }
}
