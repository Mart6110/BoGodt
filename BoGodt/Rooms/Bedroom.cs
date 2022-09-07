using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Rooms
{
    class Bedroom : Room
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
            if (NumberOfBedroom > 3)
            {
                Console.WriteLine("Vundue: 3 fags vindue");
            }
            else
            {
                Console.WriteLine("Vundue: 2 fags vindue");
            }
        }
        protected internal override void GetRoomSpecifies()
        {
            Floor();
            Door();
            Windows();
        }
    }
}
