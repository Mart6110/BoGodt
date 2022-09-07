using BoGodt.Rooms;
using System;

namespace BoGodt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new object
            Appartment appartment = new Appartment();

            appartment.NumberOfBedroom = 3; // Changing the number, sets the number of room
            appartment.AppartmentBuilder();
            appartment.GetAppartmentSpecifics();
        }
    }
}
