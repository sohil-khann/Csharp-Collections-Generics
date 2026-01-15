using System;
/*4. Personalized Meal Plan Generator
 Concepts: Generic Methods, Constraints, Interfaces
 Problem Statement: Design a system where users can choose
different meal categories like Vegetarian, Vegan, Keto, or
High-Protein.
 Hints:
 Define an interface IMealPlan with subtypes
(VegetarianMeal, VeganMeal).
 Implement a generic class Meal<T> where T : IMealPlan.
 Use a generic method to validate and generate meal plans
dynamically.
*/
namespace MealPlanGenerator
{
    public static class MealPlanMain//main file for problem
    {
        public static void Run() //main method 
        {
            

            var vegMeal = new Meal<VegetarianMeal>(new VegetarianMeal("Paneer Butter Masala")); //veg meal creation
            var veganMeal = new Meal<VeganMeal>(new VeganMeal("salad"));//vegan meal creation

            GenerateAndValidatePlan(vegMeal);
            GenerateAndValidatePlan(veganMeal);
            Console.WriteLine();
        }

        public static void GenerateAndValidatePlan<T>(Meal<T> meal) where T : IMealPlan //plan validation
        {
            if (meal.Plan.IsHealthy)
            {
                Console.WriteLine($"Generating plan: {meal.Plan.GetMealDetails()} - [VALIDATED]");
            }
            else
            {
                Console.WriteLine($"Plan: {meal.Plan.GetMealDetails()} is not healthy!");
            }
        }
    }
}
