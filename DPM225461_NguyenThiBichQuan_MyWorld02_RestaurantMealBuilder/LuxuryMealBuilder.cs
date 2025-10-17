using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class LuxuryMealBuilder : MealBuilder
    {
        public LuxuryMealBuilder()
        {
            meal = new Meal("Luxury Meal");
        }
        public override void BuildDessert()
        {
            meal["dessert"] = "Chocolate Lava Cake";
        }
        public override void BuildDrink()
        {
            meal["drink"] = "Champagne";
        }
        public override void BuildMainDish()
        {
            meal["mainDish"] = "Wagyu Beef Steak";
        }
        public override void BuildSideDish()
        {
            meal["sideDish"] = "Truffle Mashed Potatoes";
        }
    }
}
