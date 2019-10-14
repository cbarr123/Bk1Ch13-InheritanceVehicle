using System;

namespace inheritance_vehicle{

    public class Cessna : Vehicle {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public override void Drive () {
        Console.WriteLine($"The high flying {MainColor} Cessna goes ZoooooomZoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} Cessna made a rolling {TurnDirection} turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna made a rolling to a stop");
        }
    }
}