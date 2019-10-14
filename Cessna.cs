using System;

namespace inheritance_vehicle{

    public class Cessna : Vehicle {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public override void Drive () {
        Console.WriteLine("ZoooooomZoooooom!");
       

        }
    }
}