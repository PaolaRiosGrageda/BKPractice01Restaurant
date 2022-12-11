using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Level1.Practice1
{
    public struct Dish
    {
        public NameDish Name { get; set; }
        public double PriceDish { get; set; }
       
        public Dish(NameDish name, double priceDish) 
        {
            Name = name;
            PriceDish = priceDish;
        }
        public void Show()
        {
            Console.WriteLine("Plate:{0} ---------the price is: {1}",Name, PriceDish);
        }
    }
}
