using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class RoomForTwo : Room
    {
        public RoomForTwo(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            this.features = "Tv, Minibar";
        }
    }
}
