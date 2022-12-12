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
        public int Quantity { get; set; }
        public Dish(NameDish name, double priceDish, int quantity = 0) 
        {
            Name = name;
            PriceDish = priceDish;
            Quantity= quantity;
        }

        public void Show(int IdOption)
        {
            Console.WriteLine("{0}  Plate:{1} ---------the price is: {2}", IdOption, Name, PriceDish);
        }
    }
}
