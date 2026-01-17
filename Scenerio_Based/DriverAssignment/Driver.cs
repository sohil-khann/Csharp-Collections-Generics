namespace DriverAssignment
{
    public class Driver
    {
        public String VehicleName {get; set;}
        public int VehicleNumber{get;set;}

        public double Rating{get;set;}
        public bool IsAvailable { get; set; }
        public int CancellationCount { get; set; }

        public Driver(string VName,int VNumber,double rating)
        {
            VehicleName=VName;
            VehicleNumber=VNumber;
            Rating=rating;
            IsAvailable = true;
            CancellationCount = 0;
        }


    }
}