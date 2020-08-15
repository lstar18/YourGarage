using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using YourGarage.Vehicles.WaterCrafts;

namespace YourGarage.WaterCrafts
{
    class Yacht : WaterCraft
    {
        public string Size { get; set; }
        public new string Name { get; set; }

        public Yacht(string name) : base(name)
        {
        }

        public void DinnerParty()
        {
            Console.WriteLine($"The {Size} Yacht can host big dinner parties!");
        }
       
    }
}
