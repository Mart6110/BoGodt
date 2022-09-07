using BoGodt.Rooms;
using System;

namespace BoGodt
{
    class Program
    {
        static void Main(string[] args)
        {
            Appartment appartment = new Appartment();
            appartment.NumberOfBedroom = 3;
            appartment.AppartmentBuilder();
            Console.WriteLine();
            appartment.GetAppartmentSpecifics();
        }
    }
}
