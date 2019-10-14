using System;

namespace inheritance_vehicle{


    public class Zero : Vehicle {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public override void Drive () {
        Console.WriteLine("The quiet blue Zero goes ZiiiippyZiiiiippy! down the road");


       
        }
    }
}