using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            this.features = "TV, Minibar, Jacozi, couch";
        }

        protected override void SetPrice()
        {
            this.price = 100;
            if (DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
            {
                this.price += 25;
            }
        }
    }
}
