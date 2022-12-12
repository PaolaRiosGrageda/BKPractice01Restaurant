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
                Orders.Enqueue(newOrder);
            else
            {
                PrepareTop5Orders();
                DeliverTop5Orders();
            }
                Console.WriteLine(" we have five orders, we can't receive more orders");
        }
        private void PrepareTop5Orders()
        {
            Console.WriteLine("Preparing the top 5 orders....");
        }

        private void DeliverTop5Orders()
        {
            Last5PreparedOrders.Clear();
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
            Console.WriteLine("3. Show debt");
            Console.WriteLine("4. Show delivered orders");
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
                    Console.WriteLine("Usted selecciono4"); ;
                    break;
                case 4:
                    Console.WriteLine("Usted selecciono4");
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
