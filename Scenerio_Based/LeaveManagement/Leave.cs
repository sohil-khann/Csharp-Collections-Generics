using System;

namespace Scenerio_Based.LeaveManagement
{
    public class Leave
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; } // e.g., "Casual", "Sick"

        public Leave(DateTime start, DateTime end, string type)
        {
            StartDate = start;
            EndDate = end;
            LeaveType = type;
        }

        public int GetDurationInDays()
        {
            return (EndDate - StartDate).Days + 1;
        }
    }
}
