# C# Collections and Generics Practice Problems

This repository contains a collection of C# practice problems focused on **Generics**, **Type Constraints**, and **Generic Collections**. Each problem is designed to demonstrate how generics can be used to build type-safe, reusable, and maintainable systems.

## Project Structure

The project is organized into separate files for each class and interface to follow best practices for C# development.

### Implemented Problems

#### 1. Smart Warehouse Management System
- **Concepts**: Generic Classes, Constraints, Inheritance.
- **Scenario**: Manages different types of warehouse items (Electronics, Groceries, Furniture).
- **Key Files**: [Storage.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/Storage.cs), [WarehouseItem.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/WarehouseItem.cs), [SmartWareHouseMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/SmartWareHouseMain.cs).

#### 2. Dynamic Online Marketplace
- **Concepts**: Type Parameters, Generic Methods, Base Class Constraints.
- **Scenario**: A product catalog supporting various categories (Books, Clothing) with a generic discount system.
- **Key Files**: [Product.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/Product.cs), [BaseProduct.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/BaseProduct.cs), [OnlineMarketPlaceMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/OnlineMarketPlaceMain.cs).

#### 3. Multi-Level University Course Management System
- **Concepts**: Generic Classes, Abstract Class Constraints.
- **Scenario**: Handles different course evaluation types (Exams, Assignments) across various departments.
- **Key Files**: [Course.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/Course.cs), [CourseType.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/CourseType.cs), [CourseManagementMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/CourseManagementMain.cs).

#### 4. Personalized Meal Plan Generator
- **Concepts**: Generic Methods, Interface Constraints.
- **Scenario**: Generates and validates meal plans for different dietary preferences (Vegetarian, Vegan).
- **Key Files**: [Meal.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/Meal.cs), [IMealPlan.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/IMealPlan.cs), [MealPlanMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/MealPlanMain.cs).

#### 5. AI-Driven Resume Screening System
- **Concepts**: Generic Classes, Generic Methods, Constraints.
- **Scenario**: Processes resumes for different job roles (Software Engineer, Data Scientist) while ensuring type safety.
- **Key Files**: [Resume.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/Resume.cs), [JobRole.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/JobRole.cs), [ResumeScreeningMain.cs](file:///d:/Acess%20meditech/Csharp-Collections-Generics/practice_problems/ResumeScreeningMain.cs).

## Technical Features
- **No Lambda Expressions**: All implementations use standard C# block bodies for properties, methods, and constructors for maximum compatibility and clarity.
- **Clean Architecture**: Every class and interface is defined in its own file.
- **Type Safety**: Extensive use of generic constraints (`where T : class`, `where T : BaseClass`, `where T : IInterface`).

## How to Run

1. Ensure you have the .NET SDK installed.
2. Open the terminal in the project root.
3. Run the following command:

```bash
dotnet run --project practice_problems/practice_problems.csproj
```

This will execute the demonstration logic for all five practice problems in sequence.
