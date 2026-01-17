/*PROBLEM STATEMENT 3: Employee Leave Validation System
Design a leave management system.
Use:
- Dictionary<int, List<Leave>>
- HashSet<DateTime> for holidays

Tasks:
1. Validate leave request based on:
   - Max 2 consecutive leaves
   - Holidays should not count as leave
   - Max 12 casual leaves per year
2. Reject overlapping leave requests.
3. Generate leave balance report.

Edge Cases:
- Leave spanning weekends & holidays
- Year-end leave (Dec -> Jan)
- Back-to-back leave requests
- Duplicate leave dates
- Leap year dates*/
using System;
namespace Scenerio_Based.LeaveManagement{
    public class LeaveManagementMain{
public static void RunEmployeeLeaveValidationSystem()
        {
            
            LeaveManager lm = new LeaveManager();

            // Setup Holidays
            lm.AddHoliday(new DateTime(2026, 1, 26)); // Republic Day

            // Case 1: Max 2 consecutive leaves
            Console.WriteLine("Requesting 3 days (should fail):");
            lm.RequestLeave(1001, new DateTime(2026, 1, 12), new DateTime(2026, 1, 14), "Casual");

            // Case 2: Holidays don't count
            Console.WriteLine("\nRequesting leave spanning a holiday (Jan 26 is holiday):"); 
            // Jan 26 (Mon) is holiday. Requesting Fri (23) to Tue (27). 
            // Working days: Fri (23), Tue (27). Total 2 days. Should pass.
            lm.RequestLeave(1001, new DateTime(2026, 1, 23), new DateTime(2026, 1, 27), "Casual");

            // Case 3: Overlap
            Console.WriteLine("\nRequesting overlapping leave:");
            lm.RequestLeave(1001, new DateTime(2026, 1, 25), new DateTime(2026, 1, 26), "Sick");

            // Case 4: Year-end (Dec -> Jan)
            Console.WriteLine("\nRequesting Year-end leave:");
            lm.RequestLeave(1001, new DateTime(2026, 12, 31), new DateTime(2027, 1, 1), "Casual");

            lm.GenerateBalanceReport(1001, 2026);
        }
    }
}