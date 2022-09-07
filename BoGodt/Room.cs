using BoGodt.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt
{
    internal abstract class Room : Appartment
    {
        protected internal abstract void Floor();
        protected internal abstract void Door();
        protected internal abstract void Windows();
        protected internal abstract void GetRoomSpecifies();
    }
}
