using System.Collections.Generic;
using System.Numerics;
using YourGarage.AirCrafts;
using YourGarage.Cars;
using YourGarage.Vehicles.Aircrafts;
using YourGarage.Vehicles.Cars;
using YourGarage.Vehicles.WaterCrafts;
using YourGarage.WaterCrafts;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var littleLady = new Yacht("Little Lady")
            {
                FuelCapacity = "5,000 liters",
                Color = Color.pink,
                PassengerOccupancy = 10,
            };
            var sillySally = new Yacht("Silly Sally") 
            {
                FuelCapacity = "40,000 liters",
                Color = Color.orange,
                PassengerOccupancy = 30,
            };
            var goneAway = new Yacht("Gone Away")
            {
                FuelCapacity = "20,000 liters",
                Color = Color.silver,
                PassengerOccupancy = 20,
            };

            var watercraft = new List<WaterCraft>();
            watercraft.Add(littleLady);
            watercraft.Add(sillySally);
            watercraft.Add(goneAway);

            foreach (var item in watercraft)
            {
                item.Drive();
            }
            

            var mercedes1 = new Mercedes()
            {
                Color = Color.black,
                FuelCapacity = "14 gallons",
                PassengerOccupancy = 5,
                _HasCarPlay = false,
            };
            var mercedes2 = new Mercedes()
            {
                Color = Color.grey,
                FuelCapacity = "20 gallons",
                PassengerOccupancy = 7,
                _HasCarPlay = true,
            };

            var car = new List<Car>();
            car.Add(mercedes1);
            car.Add(mercedes2);

            foreach (var item in car)
            {
                item.Drive();
            }

            var plane1 = new Boeing737MAX()
            {
                Color = Color.red,
                FuelCapacity = "25,817 liters",
                PassengerOccupancy = 172,
                _isSafe = false,
            };
            var plane2 = new Boeing737MAX()
            {
                Color = Color.green,
                FuelCapacity = "25,817 liters",
                PassengerOccupancy = 210,
                _isSafe = false,
            };

            var plane = new List<AirCraft>();
            plane.Add(plane1);
            plane.Add(plane2);

            foreach (var item in plane)
            {
                item.Fly();
            }
            
        }
    }
}
