using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class Restaurant
    {
        public void ConstructMeal(MealBuilder builder)
        {
            builder.BuildMainDish();
            builder.BuildSideDish();
            builder.BuildDrink();
            builder.BuildDessert();
        }
    }
}
