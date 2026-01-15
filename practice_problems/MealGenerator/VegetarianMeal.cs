using System;

namespace MealPlanGenerator
{
    public class VegetarianMeal : IMealPlan // vegetarian meal classs
    {
        public string Name { get; set; }
        public bool IsHealthy
        {
            get { return true; }
        }

        public VegetarianMeal(string name) //constructor
        {
            Name = name;
        }

        public string GetMealDetails() //for showing details
        {
            return $"Vegetarian Meal: {Name}";
        }
    }
}
