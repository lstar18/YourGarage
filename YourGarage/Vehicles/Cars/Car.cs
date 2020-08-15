using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class Car : Vehicle
    {
        
        public override void Refuel()
        {
            Console.WriteLine($"The {FuelCapacity} of this {Color} has reached its limit.  You must refuel!");
        }
        public void Drive()
        {
            Console.WriteLine($"The {Color} car drives to school!");
        }
        public void Braking()
        {
            Console.WriteLine($"Stop! There is a deer in the road!");
        }
    }
    
}
