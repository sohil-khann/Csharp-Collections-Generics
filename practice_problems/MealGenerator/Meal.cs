using System;

namespace MealPlanGenerator
{
    public class Meal<T> where T : IMealPlan //generic class
    {
        public T Plan { get; private set; }

        public Meal(T plan) //constructor
        {
            Plan = plan;
        }

        public void ShowPlan()//show plan method
        {
            Console.WriteLine(Plan.GetMealDetails());
        }
    }
}
