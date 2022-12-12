﻿using System;
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
        public int Quantity { get; set; }
        public Beverage(NameBeverage name, double value, int quantity=0)
        {
            Name = name; 
            Value = value;
            Quantity = quantity;
        }
        public void Show(int IDOption)
        {
            Console.WriteLine("{0}  Beverage:{1}--------- the price is: {2}",IDOption, Name,Value);
        }
    }
}
