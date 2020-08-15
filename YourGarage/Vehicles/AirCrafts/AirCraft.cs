using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircrafts
{
    class AirCraft : Vehicle
    {

        public void Fly()
        {
            Console.WriteLine($"The {Color} aircraft flies high in the sky!");
        }
        public override void Refuel()
        {
            Console.WriteLine($"Stop! There is only {FuelCapacity} left before this aircraft lands abruptly!");
        }
        public void Land()
        {
            Console.WriteLine($"The aircraft will be landing soon.  Please make sure all {PassengerOccupancy} are seated!");
        }
    }
}
