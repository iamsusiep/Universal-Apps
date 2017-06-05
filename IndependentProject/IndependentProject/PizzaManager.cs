using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentProject
{
    public class PizzaManager
    {
        public static List<Pizza> GetPizzas()
        {
            var pizzas = new List<Pizza>();

            pizzas.Add( new Pizza { Image ="Assets/H.jpg", Name="Hawaiian"});
            pizzas.Add(new Pizza { Image = "Assets/V.jpg", Name = "Vegetarian" });
            pizzas.Add(new Pizza { Image = "Assets/BC.jpg", Name = "Buffalo Chicken" });
            return pizzas;
        }
    }
}
