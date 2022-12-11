using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Level1.Practice1
{
    public struct Beverage
    {
        public NameBeverage Name { get; set; }
        public double Value { get; set; }
        public Beverage(NameBeverage name, double value)
        {
            Name = name; 
            Value = value;
        }
        public void Show()
        {
            Console.WriteLine("Beverage:{0}--------- the price is: {1}", Name,Value);
        }
    }
}
