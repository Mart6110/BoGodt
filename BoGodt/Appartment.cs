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
        // Creating a list for bedrooms
        List<Bedroom> bedrooms = new List<Bedroom>();

        // Properties
        private bool frontDoor;
        private bool backDoor;
        private int numberOfBedroom = 0;

        // Encapsulation
        public bool GetFrontDoor { get => frontDoor; }
        public bool GetBackDoor { get => backDoor; }
        public int NumberOfBedroom { get => numberOfBedroom; set => numberOfBedroom = value; }

        // Method that creates the appartment
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

        // Method that output the appartment rooms
        public void GetAppartmentSpecifics()
        {
            int bedroomCount = 1;
            Console.WriteLine("Køkken");
            Console.WriteLine("Stue");
            Console.WriteLine("Badeværelse");

            // Foreach that counts the number of bedrooms in the appartment
            foreach(Bedroom b in bedrooms)
            {
                Console.WriteLine($"Soveværelse {bedroomCount}");
                bedroomCount++;
            }
        }

    }
}
