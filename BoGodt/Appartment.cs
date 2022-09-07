using BoGodt.Interface;
using BoGodt.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt
{
    class Appartment
    {
        List<Bedroom> bedrooms = new List<Bedroom>();
        private bool frontDoor;
        private bool backDoor;
        private int numberOfBedroom = 0;

        public bool GetFrontDoor { get => frontDoor; }
        public bool GetBackDoor { get => backDoor; }
        public int NumberOfBedroom { get => numberOfBedroom; set => numberOfBedroom = value; }

        public void AppartmentBuilder()
        {
            
            Kitchen kicthen = new Kitchen();
            LivingRoom livingRoom = new LivingRoom();
            BathRoom bathRoom = new BathRoom();

            switch (this.numberOfBedroom -1)
            {
                case 0:
                    break;
                case 1:
                    bedrooms.Add(new Bedroom());
                    break;
                case 2:
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    break;
                case 3:
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    break;
                case 4:
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    bedrooms.Add(new Bedroom());
                    break;
                default:
                    break;
            }
        }

        public void GetAppartmentSpecifics()
        {
            int bedroomCount = 1;
            Console.WriteLine("Køkken");
            Console.WriteLine("Stue");
            Console.WriteLine("Badeværelse");

            foreach(Bedroom b in bedrooms)
            {
                Console.WriteLine($"Soveværelse {bedroomCount}");
                bedroomCount++;
            }
        }

    }
}
