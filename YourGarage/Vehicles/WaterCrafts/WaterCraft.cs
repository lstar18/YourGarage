using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.WaterCrafts
{
    class WaterCraft : Vehicle
    {
        public string Name { get; set; }
        public WaterCraft(string name)
        {
            Name = name;
        }
        
        public void Drive()
        {
            Console.WriteLine($"{Name}, the {Color} watercraft drives to the island!");
        }
        public override void Refuel()
        {
            Console.WriteLine($"Stop! There is only {FuelCapacity} left before this water craft dies!");
        }
    }
}
