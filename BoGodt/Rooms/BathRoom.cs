using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Rooms
{
    class BathRoom : Room 
    {
        protected internal override void Floor()
        {
            Console.WriteLine("Gulv: Klinkegulv");
        }
        protected internal override void Door()
        {
            Console.WriteLine("Dør: 1 Dør");
        }
        protected internal override void Windows()
        {
            Console.WriteLine("Vindue: Matteret 1 fags vindue");
        }
        // override method to output the rooms interior
        protected internal override void GetRoomSpecifies()
        {
            Floor();
            Door();
            Windows();
        }
    }
}
