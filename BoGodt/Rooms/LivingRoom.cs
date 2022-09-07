using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoGodt.Interface;

namespace BoGodt.Rooms
{
    class LivingRoom : Room, IFrontDoor
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
            // If/else stament to get different output depending on the appartment size
            if(NumberOfBedroom > 3)
            {
                Console.WriteLine("Vundue: 3 fags vindue");
            }
            else
            {
                Console.WriteLine("Vundue: 2 fags vindue");
            }
        }
        // override method to output the rooms interior
        protected internal override void GetRoomSpecifies()
        {
            Floor();
            Door();
            Windows();
            FrontDoor();
        }
        public void FrontDoor()
        {
            Console.WriteLine("Hoveddør: Der er hoveddør i dette rum");
        }
    }
}
