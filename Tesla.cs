using System;
namespace inheritance_vehicle{
    public class Tesla : Vehicle {
        public double BatteryKWh { get; set; }

        public override void Drive () {
        Console.WriteLine($"The beautiful {MainColor} Tesla goes ZooooomerZinnng!");
        
        }
        public override void Turn()
        {
            Console.WriteLine($"The {MainColor} car made a gentle {TurnDirection} turn");
        }

    }
}