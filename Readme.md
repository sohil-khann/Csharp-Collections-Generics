# C# Collections and Generics Practice Problems

This repository contains a collection of C# practice problems focused on **Generics**, **Type Constraints**, **Generic Collections**, and **Real-World Scenarios**. Each problem demonstrates how to build type-safe, reusable, and maintainable systems.

## Project Structure

The project is organized into two main sections:

### 1. Practice Problems (Generics & Type Safety)

#### Smart Warehouse Management System
- **Concepts**: Generic Classes, Constraints, Inheritance
- **Scenario**: Manages different types of warehouse items (Electronics, Groceries, Furniture)
- **Key Files**: Storage.cs, WarehouseItem.cs, SmartWareHouseMain.cs

#### Dynamic Online Marketplace
- **Concepts**: Type Parameters, Generic Methods, Base Class Constraints
- **Scenario**: Product catalog supporting various categories with generic discount system
- **Key Files**: Product.cs, BaseProduct.cs, OnlineMarketPlaceMain.cs

#### Multi-Level University Course Management System
- **Concepts**: Generic Classes, Abstract Class Constraints
- **Scenario**: Handles different course evaluation types across various departments
- **Key Files**: Course.cs, CourseType.cs, CourseManagementMain.cs

#### Personalized Meal Plan Generator
- **Concepts**: Generic Methods, Interface Constraints
- **Scenario**: Generates and validates meal plans for different dietary preferences
- **Key Files**: Meal.cs, IMealPlan.cs, MealPlanMain.cs

#### AI-Driven Resume Screening System
- **Concepts**: Generic Classes, Generic Methods, Constraints
- **Scenario**: Processes resumes for different job roles while ensuring type safety
- **Key Files**: Resume.cs, JobRole.cs, ResumeScreeningMain.cs

### 2. Scenario-Based Problems (Collections & Real-World Applications)

#### Cab Driver Assignment System
- **Collections**: List, SortedList, Dictionary
- **Scenario**: Assigns nearest available driver with tie-breaking by rating and cancellation penalties
- **Key Files**: DriverAssigning.cs, Driver.cs, DriverAssignmentMain.cs

#### Online Exam Result Normalization
- **Collections**: Dictionary, SortedDictionary
- **Scenario**: Processes marks with grace marks, normalizes scores, and generates ranks
- **Key Files**: ExamNormalizer.cs, ExamResult.cs, ExamNormalizationMain.cs

#### Bank Transaction Fraud Detector
- **Collections**: Dictionary, Queue, List
- **Scenario**: Monitors transactions for suspicious activity (high-value withdrawals, frequent transfers)
- **Key Files**: FraudDetector.cs, Transaction.cs

#### Employee Leave Management System
- **Collections**: Dictionary, List, HashSet
- **Scenario**: Manages leave requests, checks overlaps, enforces consecutive leave and yearly limits
- **Key Files**: LeaveManager.cs, Leave.cs

#### Smart Shopping Cart
- **Collections**: Dictionary
- **Scenario**: Implements dynamic discounts ("Buy 2 Get 1 Free") with delivery fees
- **Key Files**: CartManager.cs, CartItem.cs

## Technical Features
- **No Lambda Expressions**: Standard C# block bodies for maximum compatibility
- **Clean Architecture**: Each class and interface in separate files
- **Type Safety**: Extensive use of generic constraints
- **Real-World Patterns**: Collections-based solutions for practical scenarios

## How to Run

