using System;
namespace inheritance_vehicle{
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public string TurnDirection {get; set;}

        public virtual void Drive () {
            Console.WriteLine("VrooomVrooom!");
        }

        public virtual void Turn ()
        {
            Console.WriteLine("The car made a gentle left turn");
        }

        public virtual void Stop ()
        {
            Console.WriteLine("The vehicle rolled gently to a halt");
        }


    }

}