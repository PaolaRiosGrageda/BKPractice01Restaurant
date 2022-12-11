using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Level1.Practice1
{
    public struct Menu
    {

        public List<Dish> Dishes;
        public List<Beverage> Beverages;

        public Menu()
        {
            Dishes = new List<Dish>();
            Beverages = new List<Beverage>();

            //Adding Dishes
            Dishes.Add(new Dish() { Name = NameDish.Spaguetti, PriceDish=10.99});
            Dishes.Add(new Dish() { Name = NameDish.Calzone, PriceDish = 6 });
            Dishes.Add(new Dish() { Name = NameDish.Lasagna, PriceDish = 12.99 });
            Dishes.Add(new Dish() { Name = NameDish.Pizza, PriceDish = 8 });
            Beverages.Add(new Beverage() { Name= NameBeverage.Soda, Value= 6.5 });
            Beverages.Add(new Beverage() { Name = NameBeverage.Wine, Value = 9 });
            Beverages.Add(new Beverage() { Name = NameBeverage.Beer, Value = 7.5 });
        }

        public void Show()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("The menu of the restaurant ---Practice01---- es:");
            Console.WriteLine("Dishes:");
            for (int i = 0; i < Dishes.Count; i++)
            {
                Dishes[i].Show();
            }
            Console.WriteLine("Beverages:");
            for (int i = 0; i < Beverages.Count; i++)
            {
                Beverages[i].Show();
            }
            Console.WriteLine("----------------------");

        }


    }
}
