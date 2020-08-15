using System;
using System.Collections.Generic;
using System.Text;
using YourGarage.Vehicles.Cars;

namespace YourGarage.Cars
{
    class Mercedes : Car
    {
        public bool _HasCarPlay { get; set; } = true;
        
        public void Audio()
        {
            if (_HasCarPlay)
            {
                Console.WriteLine($"You can plug in your phone to listen to your music since your {Color} Mercedes has CarPlay!");
            }
            else
            {
                Console.WriteLine($"You have to listen to your radio!");
            }
        }
    }
}
