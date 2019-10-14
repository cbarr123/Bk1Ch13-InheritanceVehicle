using System;

namespace inheritance_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Zero fxs = new Zero ();
            Tesla modelS = new Tesla ();
            Cessna mx410 = new Cessna ();
            Ram C1500 = new Ram ();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            C1500.Drive();
        }
    }
}
