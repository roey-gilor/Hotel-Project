using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    public class Guest
    {
        private int id;
        private string name;
        public int Id 
        {
            set { this.id = value; }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set { this.name = value; }
            get
            {
                return this.name;
            }
        }
        public override string ToString()
        {
            return "id: " + this.id + " name: " + this.name;
        }
    }
}
