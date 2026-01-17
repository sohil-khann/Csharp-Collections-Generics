/*



PROBLEM STATEMENT 4: Bank Transaction Fraud Detector
Implement fraud detection logic in a banking system.
Use:
- Dictionary<long, List<Transaction>>
- Queue<Transaction>

Tasks:
1. Flag account if:
   - More than 3 withdrawals in 10 minutes
   - Withdrawal > 80% of balance
2. Generate suspicious transaction report.

Edge Cases:
- Transactions at exact 10-minute boundary
- Balance changing after each transaction
- Same timestamp transactions
- Zero balance withdrawal
- Queue not cleared properly
*/
namespace Scenerio_Based.FraudDetection
{
    public class FraudDetectionMain
    {
        
    

        

      public   static void RunBankTransactionFraudDetector()
        {
            FraudDetector detector = new FraudDetector();
            long accNo = 123456789;
            detector.SetBalance(accNo, 10000);

            Console.WriteLine("Initial Balance: ₹10000");

            // Case 1: Withdrawal > 80%
            Console.WriteLine("\nProcessing ₹9000 withdrawal (90%):");
            detector.ProcessTransaction(new Transaction(1, accNo, 9000, DateTime.Now, "Withdrawal"));

            // Reset for next test
            detector.SetBalance(accNo, 5000);
            Console.WriteLine("\nBalance reset to ₹5000. Processing multiple withdrawals within 10 mins:");
            
            DateTime now = DateTime.Now;
            detector.ProcessTransaction(new Transaction(2, accNo, 100, now, "Withdrawal"));
            detector.ProcessTransaction(new Transaction(3, accNo, 100, now.AddMinutes(2), "Withdrawal"));
            detector.ProcessTransaction(new Transaction(4, accNo, 100, now.AddMinutes(5), "Withdrawal"));
            detector.ProcessTransaction(new Transaction(5, accNo, 100, now.AddMinutes(8), "Withdrawal")); // 4th withdrawal

            // Edge case: Zero balance withdrawal
            detector.SetBalance(accNo, 0);
            Console.WriteLine("\nProcessing withdrawal from ₹0 balance:");
            detector.ProcessTransaction(new Transaction(6, accNo, 50, now.AddMinutes(20), "Withdrawal"));

            detector.GenerateSuspiciousReport();
        }
    }
}