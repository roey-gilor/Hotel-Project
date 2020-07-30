using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public abstract class Room
    {
        protected int roomNumber;
        protected float price;
        protected Guest guest;
        protected bool isClean;
        protected string features;
        public Room(int roomNumber, float price)
        {
            this.roomNumber = roomNumber;
            this.price = price;
            SetPrice();
            SetFeatures();
        }
        internal void SetGuest (Guest guest)
        {
            this.guest = guest;
        }
        internal void SetRoomNumber (int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        protected virtual void SetPrice ()
        {
            this.price = 50;
            if (DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
            {
                this.price += 25;
            }
        }
        protected abstract void SetFeatures();
        public int RoomNumber
        {
            get
            {
                return this.roomNumber;
            }
        }
        public float Price
        {
            get
            {
                return this.price;
            }
        }
        public Guest Guest
        {
            get
            {
                return this.guest;
            }
        }
        public bool IsClean
        {
            set { this.isClean = value; }
            get
            {
                return this.isClean;
            }
        }
        public string Features
        {
            get
            {
                return this.features;
            }
        }
    }
}
