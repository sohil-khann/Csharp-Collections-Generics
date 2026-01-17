# Scenario Based Problems (Collections & Generics)

This directory contains complex real-world scenarios that leverage various C# collections like `List`, `Dictionary`, `SortedList`, `Queue`, and `Stack`.

## Implemented Scenarios

### 1. Cab Driver Assignment System
- **Collections**: `List`, `SortedList`, `Dictionary`
- **Scenario**: Assigns the nearest available driver to a passenger. Handles tie-breaking by rating and penalizes drivers for frequent cancellations.
- **Key Files**: 
  - [DriverAssigning.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/DriverAssignment/DriverAssigning.cs)
  - [Driver.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/DriverAssignment/Driver.cs)
  - [DriverAssignmentMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/DriverAssignment/DriverAssignmentMain.cs)

### 2. Online Exam Result Normalization
- **Collections**: `Dictionary`, `SortedDictionary`
- **Scenario**: Processes student marks with grace marks, normalizes scores if class average is low, and generates ranks using sorted collections.
- **Key Files**:
  - [ExamNormalizer.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/ExamNormalization/ExamNormalizer.cs)
  - [ExamResult.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/ExamNormalization/ExamResult.cs)
  - [ExamNormalizationMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/ExamNormalization/ExamNormalizationMain.cs)

### 3. Bank Transaction Fraud Detector
- **Collections**: `Dictionary`, `Queue`, `List`
- **Scenario**: Monitors transactions for suspicious activity such as high-value withdrawals or frequent small withdrawals in a short time.
- **Key Files**: 
  - [FraudDetector.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/FraudDetection/FraudDetector.cs)
  - [Transaction.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/FraudDetection/Transaction.cs)

### 4. Employee Leave Management System
- **Collections**: `Dictionary`, `List`, `HashSet`
- **Scenario**: Manages leave requests, checks for overlaps, and enforces limits on consecutive leaves and yearly balances.
- **Key Files**: 
  - [LeaveManager.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/LeaveManagement/LeaveManager.cs)
  - [Leave.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/LeaveManagement/Leave.cs)

### 5. Smart Shopping Cart
- **Collections**: `Dictionary`
- **Scenario**: Implements complex discount logic like "Buy 2 Get 1 Free" and calculates final bills with dynamic delivery fees.
- **Key Files**: 
  - [CartManager.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/ShoppingCart/CartManager.cs)
  - [CartItem.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/Scenerio_Based/ShoppingCart/CartItem.cs)

## How to Run
1. Ensure you have the .NET SDK installed.
2. Open the terminal in the `Scenerio_Based` directory.
3. Run:
   ```bash
   dotnet run
   ```
