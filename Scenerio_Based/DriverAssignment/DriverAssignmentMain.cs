using System;
using System.Collections.Generic;

namespace DriverAssignment
{
    public class DriverAssignmentMain
    {
        public static void RunCabDriverAssignmentSystem()
        {
            Console.WriteLine("--- Cab Driver Assignment System ---");
            DriverAssigning system = new DriverAssigning();

            Driver d1 = new Driver("Amit", 101, 4.5);
            Driver d2 = new Driver("Sita", 102, 4.8);
            Driver d3 = new Driver("Rahul", 103, 4.2);
            Driver d4 = new Driver("Priya", 104, 4.8);

            system.AddDriver(d1);
            system.AddDriver(d2);
            system.AddDriver(d3);
            system.AddDriver(d4);

            // Simulation: Passenger wants a cab
            Dictionary<Driver, double> distances = new Dictionary<Driver, double>
            {
                { d1, 5.2 },
                { d2, 3.5 },
                { d3, 3.5 }, // Same distance as Sita, but Sita has higher rating
                { d4, 2.1 }
            };

            Console.WriteLine("\nAssigning first ride:");
            Driver assigned1 = system.AssignDriver(distances);

            Console.WriteLine("\nAssigning second ride (Priya is now unavailable):");
            Driver assigned2 = system.AssignDriver(distances);

            Console.WriteLine($"\nCancelling {assigned2.VehicleName}'s ride to test penalties:");
            system.CancelRide(assigned2); 
            system.CancelRide(assigned2);
            system.CancelRide(assigned2);
            system.CancelRide(assigned2); // 4th cancellation should trigger penalty

            Console.WriteLine("\nAssigning third ride (Rahul is available again but with lower rating):");
            Driver assigned3 = system.AssignDriver(distances);
            
            Console.WriteLine("\nAll drivers become unavailable:");
            d1.IsAvailable = false;
            d2.IsAvailable = false;
            d3.IsAvailable = false;
            d4.IsAvailable = false;
            system.AssignDriver(distances);
        }
    }
}