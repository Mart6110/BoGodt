using BoGodt.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Rooms
{
    class Kitchen : Room, IBackDoor
    {
        protected internal override void Floor()
        {
            Console.WriteLine("Gulv: trægulv");
        }
        protected internal override void Door()
        {
            Console.WriteLine("Dør: 1 Dør");
        }
        protected internal override void Windows()
        {
            Console.WriteLine("Vindue: 1 fags vindue");
        }

        public void BackDoor()
        {
            Console.WriteLine("Bagdør: Køkken har en bagdør");
        }
        // override method to output the rooms interior
        protected internal override void GetRoomSpecifies()
        {
            Floor();
            Door();
            Windows();
            BackDoor();
        }
    }
}
