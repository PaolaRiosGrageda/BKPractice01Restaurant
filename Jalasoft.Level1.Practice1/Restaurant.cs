using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.Level1.Practice1
{
    public struct Restaurant
    {
        private Queue<Order> Orders;

        private Menu menu;
        public Restaurant()
        {
            menu = new Menu();
            Orders = new Queue<Order>();
        }

        public void AddOrder(Order newOrder)
        {
            if (Orders.Count <= 5)
                Orders.Enqueue(newOrder);
            else
                Console.WriteLine(" we have five orders, we can't receive more orders");
        }

        public Order ProcessOrder()
        {
           return Orders.Dequeue();
        }
       
    }
}
