using System;
using System.Collections.Generic;

namespace Scenerio_Based.LeaveManagement
{
    public class LeaveManager
    {
        private Dictionary<int, List<Leave>> employeeLeaves;
        private HashSet<DateTime> holidays;
        private const int MaxCasualLeaves = 12;

        public LeaveManager()
        {
            employeeLeaves = new Dictionary<int, List<Leave>>();
            holidays = new HashSet<DateTime>();
        }

        public void AddHoliday(DateTime date)
        {
            holidays.Add(date.Date);
        }

        public bool RequestLeave(int empId, DateTime start, DateTime end, string type)
        {
            start = start.Date;
            end = end.Date;

            if (end < start)
            {
                Console.WriteLine("Error: End date cannot be before start date.");
                return false;
            }

            // 1. Calculate actual leave days (excluding holidays and weekends)
            int actualDays = 0;
            List<DateTime> leaveDates = new List<DateTime>();
            for (DateTime dt = start; dt <= end; dt = dt.AddDays(1))
            {
                if (!holidays.Contains(dt) && dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    actualDays++;
                    leaveDates.Add(dt);
                }
            }

            if (actualDays == 0)
            {
                Console.WriteLine("Leave request rejected: No working days in the requested period.");
                return false;
            }

            // 2. Max 2 consecutive leaves check
            if (actualDays > 2)
            {
                Console.WriteLine("Leave request rejected: Cannot take more than 2 consecutive working days.");
                return false;
            }

            // 3. Overlap check
            if (!employeeLeaves.ContainsKey(empId))
            {
                employeeLeaves[empId] = new List<Leave>();
            }

            foreach (var existingLeave in employeeLeaves[empId])
            {
                if (start <= existingLeave.EndDate && end >= existingLeave.StartDate)
                {
                    Console.WriteLine("Leave request rejected: Overlaps with an existing leave.");
                    return false;
                }
            }

            // 4. Max 12 casual leaves per year check
            if (type == "Casual")
            {
                int currentYear = start.Year;
                int usedCasualLeaves = 0;
                foreach (var leave in employeeLeaves[empId])
                {
                    if (leave.LeaveType == "Casual" && leave.StartDate.Year == currentYear)
                    {
                        // Need to count working days for existing leaves too
                        usedCasualLeaves += GetWorkingDays(leave.StartDate, leave.EndDate);
                    }
                }

                if (usedCasualLeaves + actualDays > MaxCasualLeaves)
                {
                    Console.WriteLine("Leave request rejected: Annual casual leave limit exceeded.");
                    return false;
                }
            }

            // If all checks pass, add the leave
            employeeLeaves[empId].Add(new Leave(start, end, type));
            Console.WriteLine("Leave approved for Employee " + empId + " from " + start.ToShortDateString() + " to " + end.ToShortDateString());
            return true;
        }

        private int GetWorkingDays(DateTime start, DateTime end)
        {
            int count = 0;
            for (DateTime dt = start; dt <= end; dt = dt.AddDays(1))
            {
                if (!holidays.Contains(dt) && dt.DayOfWeek != DayOfWeek.Saturday && dt.DayOfWeek != DayOfWeek.Sunday)
                {
                    count++;
                }
            }
            return count;
        }

        public void GenerateBalanceReport(int empId, int year)
        {
            int usedCasual = 0;
            if (employeeLeaves.ContainsKey(empId))
            {
                foreach (var leave in employeeLeaves[empId])
                {
                    if (leave.LeaveType == "Casual" && leave.StartDate.Year == year)
                    {
                        usedCasual += GetWorkingDays(leave.StartDate, leave.EndDate);
                    }
                }
            }

            Console.WriteLine("\n--- Leave Balance Report for Employee " + empId + " (Year: " + year + ") ---");
            Console.WriteLine("Casual Leaves Used: " + usedCasual);
            Console.WriteLine("Casual Leaves Remaining: " + (MaxCasualLeaves - usedCasual));
        }
    }
}
