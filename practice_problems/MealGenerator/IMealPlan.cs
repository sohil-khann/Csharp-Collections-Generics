using System;

namespace MealPlanGenerator
{
    public interface IMealPlan //interface
    {
        string GetMealDetails(); //abstract method
        bool IsHealthy { get; } 
    }
}
