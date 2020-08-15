using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage
{
    abstract class Vehicle
    {
        public Color Color { get; set; }
        public string FuelCapacity { get; set; }
        public int PassengerOccupancy { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine($"You have half of your {FuelCapacity} left!");
        }
    }
}
