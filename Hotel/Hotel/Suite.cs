using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite : Room
    {
        public Suite(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatures()
        {
            this.features = "TV, Minibar, Jacozi, couch, balcony";
        }

        protected override void SetPrice()
        {
            this.price = 150;
            if (DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
            {
                this.price += 25;
            }
        }
    }
}
