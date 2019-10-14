using System;

namespace inheritance_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Zero fxs = new Zero ()
            {
                MainColor = "red",
            };

            Tesla modelS = new Tesla ()
            {
                MainColor = "blue", 
                TurnDirection = "left",
            };
            Cessna mx410 = new Cessna ()
            {
                MainColor = "purple",
                TurnDirection = "right",
            };
            Ram C1500 = new Ram ()
            {
                 MainColor = "coal black",
            };

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine();
            C1500.Drive();
            C1500.Turn();
            C1500.Stop();
            Console.WriteLine();
        }
    }
}
