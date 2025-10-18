using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            MealBuilder builder1 = new KidsMealBuilder();
            restaurant.ConstructMeal(builder1);
            builder1.Meal.Show();

            MealBuilder builder2 = new VegetarianMealBuilder();
            restaurant.ConstructMeal(builder2);
            builder2.Meal.Show();

            MealBuilder builder3 = new LuxuryMealBuilder();
            restaurant.ConstructMeal(builder3);
            builder3.Meal.Show();

            Console.ReadKey();

        }
    }
}
