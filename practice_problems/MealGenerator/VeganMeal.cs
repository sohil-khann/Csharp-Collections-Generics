using System;

namespace MealPlanGenerator
{
    public class VeganMeal : IMealPlan //class for veg meal
    {
        public string Name { get; set; }
        public bool IsHealthy
        {
            get { return true; }
        }

        public VeganMeal(string name) // constructor
        {
            Name = name;
        }

        public string GetMealDetails() //show details
        {
            return $"Vegan Meal: {Name}";
        }
    }
}
