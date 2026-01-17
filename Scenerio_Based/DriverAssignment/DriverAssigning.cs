using System;
using System.Collections.Generic;
using System.Linq;

namespace DriverAssignment
{
    public class DriverAssigning
    {
        private List<Driver> drivers = new List<Driver>();

        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }

        public Driver AssignDriver(Dictionary<Driver, double> driverDistances)
        {
            // Use SortedList to store drivers by distance. 
            // Key: Distance, Value: Driver
            SortedList<double, Driver> sortedDrivers = new SortedList<double, Driver>();

            foreach (var driver in drivers)
            {
                if (!driver.IsAvailable) continue;

                if (driverDistances.TryGetValue(driver, out double dist))
                {
                    if (!sortedDrivers.ContainsKey(dist))
                    {
                        sortedDrivers.Add(dist, driver);
                    }
                    else
                    {
                        // Tie-breaker: Highest rating
                        if (driver.Rating > sortedDrivers[dist].Rating)
                        {
                            sortedDrivers[dist] = driver;
                        }
                    }
                }
            }

            if (sortedDrivers.Count == 0)
            {
                Console.WriteLine("No drivers available.");
                return null;
            }

            // The first element in SortedList is the one with the smallest distance
            var bestEntry = sortedDrivers.First();
            Driver bestDriver = bestEntry.Value;
            double minDistance = bestEntry.Key;

            bestDriver.IsAvailable = false;
            Console.WriteLine($"Driver {bestDriver.VehicleName} assigned. Distance: {minDistance:F2}, Rating: {bestDriver.Rating}");
            
            return bestDriver;
        }

        public void CancelRide(Driver driver)
        {
            if (driver == null) return;

            driver.IsAvailable = true;
            driver.CancellationCount++;
            
            Console.WriteLine($"Ride cancelled for driver {driver.VehicleName}. Total cancellations: {driver.CancellationCount}");

            if (driver.CancellationCount >= 3)
            {
                driver.Rating -= 0.5; // Penalty
                Console.WriteLine($"Driver {driver.VehicleName} penalized for frequent cancellations. New Rating: {driver.Rating}");
            }
        }
    }
}