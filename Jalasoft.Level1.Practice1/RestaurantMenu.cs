using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Jalasoft.Level1.Practice1
{
    public struct RestaurantMenu
    {
        private Menu MenuRestaurant;
       
        private Queue<Order> Orders;
        private Queue<Order> Last5PreparedOrders;

        private int exitOption;
        public RestaurantMenu() {
            MenuRestaurant= new Menu();
           
            exitOption = 0;
            Orders = new Queue<Order>();
            Last5PreparedOrders = new Queue<Order>();
        }
        public void AddOrder(Order newOrder)
        {
            if (Orders.Count < 5)
            {
                Orders.Enqueue(newOrder);
                Console.WriteLine("We have {0} order preparing", Orders.Count);
            }

            if(Orders.Count == 5)
            {
                PrepareTop5Orders();
                DeliverTop5Orders();
            }
                
        }
        private void PrepareTop5Orders()
        {
            Console.WriteLine("Preparing the top 5 orders....");
        }

        private void DeliverTop5Orders()
        {
            Last5PreparedOrders.Clear();
            Console.WriteLine("delivering five orders");
            for (int i = 0; i < 5; i++)
            {
                Order deliveredOrder = Orders.Dequeue();
                Console.WriteLine(deliveredOrder.GetDeliverOrderInformation());
                Last5PreparedOrders.Enqueue(deliveredOrder);
            }    
        }

        // Interface
        private int ChooseOption()
        {
            this.ShowOptions();
            string option= Console.ReadLine();
            int selection = int.Parse(option);  
            return selection; 
        }
        private void ShowOptions()
        {
            Console.WriteLine("");
            Console.WriteLine("--------------");
            Console.WriteLine("1.Show Menu ");
            Console.WriteLine("2. Register Order");
            Console.WriteLine("3. Show 5 Orders");
            Console.WriteLine("4. Show delivered 5 orders");
            Console.WriteLine("0. Exit");
        }
        public void Start()
        {
            int option;
            do
            {
                option= ChooseOption();
                ExecuteOption(option);
            }while (option!= exitOption);
             
           

        }
        private void ExecuteOption(int option)
        {
            switch(option)
            {
                case 1:
                    MenuRestaurant.ShowDishes();
                    MenuRestaurant.ShowBeverages();
                    break;
                case 2:
                    AddOrder(new Order());
                    break;
                case 3:
                    PrepareTop5Orders();
                    break;
                case 4:
                    DeliverTop5Orders();
                    break;

                case 0:
                    Console.WriteLine("Close App");
                    break;
                default:
                    break;
            }

        }



    }
}
