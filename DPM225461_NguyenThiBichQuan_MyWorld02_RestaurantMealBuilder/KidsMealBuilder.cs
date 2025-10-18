using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class KidsMealBuilder: MealBuilder
    {
        public KidsMealBuilder() {
            meal = new Meal("Kids Meal");
        }

        public override void BuildMainDish()
        {
            meal["mainDish"] = "Chicken Nuggets";
        }

        public override void BuildSideDish()
        {
            meal["sideDish"] = "French Fries";
        }

        public override void BuildDrink()
        {
            meal["drink"] = "Apple Juice";
        }

        public override void BuildDessert()
        {
            meal["dessert"] = "Ice Cream";
        }
    }
}
