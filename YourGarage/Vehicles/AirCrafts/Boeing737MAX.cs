using System;
using System.Collections.Generic;
using System.Text;
using YourGarage.Vehicles.Aircrafts;

namespace YourGarage.AirCrafts
{
    class Boeing737MAX : AirCraft
    {
        public bool _isSafe { get; set; } = false;

        public void Safety()
        {
            if (_isSafe)
            {
                Console.WriteLine($"I would still not fly this {Color} plane!");
            }
            else
            {
                Console.WriteLine($"DO NOT FLY THIS PLANE!");
            }

        }
    }
}
