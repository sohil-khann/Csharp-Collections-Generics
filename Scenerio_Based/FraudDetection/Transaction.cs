using System;

namespace Scenerio_Based.FraudDetection
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public long AccountNumber { get; set; }
        public double Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; } // "Withdrawal", "Deposit"

        public Transaction(long id, long accNo, double amount, DateTime time, string type)
        {
            TransactionId = id;
            AccountNumber = accNo;
            Amount = amount;
            Timestamp = time;
            Type = type;
        }
    }
}
