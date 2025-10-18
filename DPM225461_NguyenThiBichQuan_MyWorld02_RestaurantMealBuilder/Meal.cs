using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld02_RestaurantMealBuilder
{
    public class Meal
    {
        private string mealType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public Meal(string mealType)
        {
            this.mealType = mealType;
        }

        public string this[string key]
        {
            get { return parts[key]; } 
            set { parts[key] = value; } 
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Meal Type: {0}", mealType);
            Console.WriteLine(" Main Dish : {0}", parts["mainDish"]);
            Console.WriteLine(" Side Dish : {0}", parts["sideDish"]);
            Console.WriteLine(" Drink     : {0}", parts["drink"]);
            Console.WriteLine(" Dessert   : {0}", parts["dessert"]);
        }
    }
}
