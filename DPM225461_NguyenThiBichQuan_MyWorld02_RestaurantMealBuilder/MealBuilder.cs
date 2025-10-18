using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public abstract class MealBuilder
    {
        protected Meal meal;

        public Meal Meal { 
            get { return meal; }
        }

        public abstract void BuildMainDish();
        public abstract void BuildSideDish();
        public abstract void BuildDrink();
        public abstract void BuildDessert();
    }
}
