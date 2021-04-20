using System;
using System.Device.Location;

namespace WhereAmI
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting GeoCoordinate Watcher...");

            //Make sure to add a reference to 'System.Device', you can search in the reference manager for Device
            //Use the GeoCoordinate Watcher 
            var watcher = new GeoCoordinateWatcher();

            watcher.StatusChanged += (s, e) =>
            {
                Console.WriteLine($"GeoCoordinateWatcher:StatusChanged:{e.Status}");
            };

            watcher.PositionChanged += (s,e) =>
            {
                watcher.Stop();
                Console.WriteLine($"GeoCoordinateWatcher:PositionChanged:{e.Position.Location}");
            
                //Use the Map Image REST API
                MapImage.Show(e.Position.Location);
            
            };

            watcher.MovementThreshold = 100;

            watcher.Start();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}