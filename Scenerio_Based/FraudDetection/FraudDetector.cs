using System;
using System.Collections.Generic;

namespace Scenerio_Based.FraudDetection
{
    public class FraudDetector
    {
        private Dictionary<long, List<Transaction>> accountHistory;
        private Dictionary<long, double> accountBalances;
        private List<Transaction> suspiciousTransactions;

        public FraudDetector()
        {
            accountHistory = new Dictionary<long, List<Transaction>>();
            accountBalances = new Dictionary<long, double>();
            suspiciousTransactions = new List<Transaction>();
        }

        public void SetBalance(long accNo, double balance)
        {
            accountBalances[accNo] = balance;
        }

        public void ProcessTransaction(Transaction t)
        {
            if (!accountBalances.ContainsKey(t.AccountNumber))
            {
                accountBalances[t.AccountNumber] = 0;
            }

            if (!accountHistory.ContainsKey(t.AccountNumber))
            {
                accountHistory[t.AccountNumber] = new List<Transaction>();
            }

            bool isFraudulent = false;

            if (t.Type == "Withdrawal")
            {
                // 1. Check if withdrawal > 80% of current balance
                double currentBalance = accountBalances[t.AccountNumber];
                if (currentBalance > 0 && t.Amount > (currentBalance * 0.8))
                {
                    isFraudulent = true;
                    Console.WriteLine("[ALERT] Fraud Detected: Withdrawal > 80% of balance for Account " + t.AccountNumber);
                }
                else if (currentBalance == 0 && t.Amount > 0)
                {
                    isFraudulent = true;
                    Console.WriteLine("[ALERT] Fraud Detected: Withdrawal from Zero Balance for Account " + t.AccountNumber);
                }

                // 2. Check for > 3 withdrawals in 10 minutes
                Queue<Transaction> recentWithdrawals = new Queue<Transaction>();
                foreach (var hist in accountHistory[t.AccountNumber])
                {
                    if (hist.Type == "Withdrawal")
                    {
                        // Check if within 10 minutes of current transaction
                        double minutesDiff = (t.Timestamp - hist.Timestamp).TotalMinutes;
                        if (minutesDiff >= 0 && minutesDiff <= 10)
                        {
                            recentWithdrawals.Enqueue(hist);
                        }
                    }
                }

                if (recentWithdrawals.Count >= 3) // If there are already 3, this 4th one flags it
                {
                    isFraudulent = true;
                    Console.WriteLine("[ALERT] Fraud Detected: More than 3 withdrawals in 10 minutes for Account " + t.AccountNumber);
                }

                // Update balance after withdrawal
                accountBalances[t.AccountNumber] -= t.Amount;
            }
            else if (t.Type == "Deposit")
            {
                accountBalances[t.AccountNumber] += t.Amount;
            }

            if (isFraudulent)
            {
                suspiciousTransactions.Add(t);
            }

            accountHistory[t.AccountNumber].Add(t);
        }

        public void GenerateSuspiciousReport()
        {
            Console.WriteLine("\n--- SUSPICIOUS TRANSACTION REPORT ---");
            if (suspiciousTransactions.Count == 0)
            {
                Console.WriteLine("No suspicious transactions found.");
                return;
            }

            foreach (var t in suspiciousTransactions)
            {
                Console.WriteLine("ID: " + t.TransactionId + " | Acc: " + t.AccountNumber + 
                                  " | Amount: " + t.Amount + " | Time: " + t.Timestamp + " | Type: " + t.Type);
            }
        }
    }
}
