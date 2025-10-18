using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class VegetarianMealBuilder : MealBuilder
    {
        public VegetarianMealBuilder()
        {
            meal = new Meal("Vegetarian Meal");
        }
        public override void BuildDessert()
        {
            meal["dessert"] = "Fruit Salad";
        }

        public override void BuildDrink()
        {
            meal["drink"] = "Fresh Orange Juice";
        }

        public override void BuildMainDish()
        {
            meal["mainDish"] = "Veggie Burger";
        }

        public override void BuildSideDish()
        {
            meal["sideDish"] = "Garden Salad";
        }
    }
}
