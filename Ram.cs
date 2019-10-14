using System;

namespace inheritance_vehicle{

        public class Ram : Vehicle {  // Gas powered truck
            public double FuelCapacity { get; set; }
                
            public override void Drive () {
                    Console.WriteLine($"The loud {MainColor} Ram sings a sonlg like ChuggaChugga!");
            }
        }
}