using System;
namespace inheritance_vehicle{
    public class Tesla : Vehicle {
        public double BatteryKWh { get; set; }

        public override void Drive () {
        Console.WriteLine("The beautiful green Tesla goes ZooooomerZinnng!");


        }

    }
}