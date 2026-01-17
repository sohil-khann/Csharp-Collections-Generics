using System;
using System.Collections.Generic;
using Scenerio_Based.ShoppingCart;
using Scenerio_Based.LeaveManagement;
using Scenerio_Based.FraudDetection;

using StudentAnalysis;

namespace Scenerio_Based
{
    class Program
    {
        static void Main(string[] args)
        {
            //for student analyzer
            // StudentMain.RunStudentPerformanceAnalyzer();
            
            
            //for cart management
            // CartMain.RunSmartShoppingCartSystem();

          
//for Leave Management System
            // LeaveManagementMain.RunEmployeeLeaveValidationSystem();

        
//for detecting frauds in transaction
            FraudDetectionMain.RunBankTransactionFraudDetector();

         
            Console.ReadKey();
        }

       

    }
}
