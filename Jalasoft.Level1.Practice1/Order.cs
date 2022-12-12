namespace Jalasoft.Level1.Practice1
{
    public struct Order
    {
        public int NumberOrder;
        public string NameCustomer;
        public Menu MenuOrder;
        public List<Dish> DishesOrder;
        public List<Beverage> BeverageOrders;
        public PaymentMethod Payment;
        public Order()
        {
            MenuOrder = new Menu();
            DishesOrder = new List<Dish>();
            BeverageOrders = new List<Beverage>();

            Console.WriteLine("==========================");
            Console.WriteLine("1. Enter the name of customer");
            NameCustomer = Console.ReadLine();
            Console.WriteLine("==========================");
            bool menuContinue = true;
            do
            {
                MenuOrder.ShowDishes();

                int orderSelection = int.Parse(Console.ReadLine());
                if (orderSelection > 0 && orderSelection <= MenuOrder.GetTotalDishes())
                {
                    var selectedDish = MenuOrder.Dishes[orderSelection - 1];

                    Console.WriteLine("Enter the quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    DishesOrder.Add(new Dish(selectedDish.Name, selectedDish.PriceDish, quantity));
                    Console.WriteLine("Do you want to add other dish? Y/N");
                }
                else
                    Console.WriteLine(" Please select a option of the menu ");
                if (Console.ReadLine().ToLower() == "n")
                    menuContinue = false;
            } while (menuContinue);

            menuContinue= true;
            Console.WriteLine("The total price for Dishes is: {0}", TotalPriceDishes());
            do
            {
                Console.WriteLine("=================================");
                Console.WriteLine("please Select a Beverage of the menu ");
                MenuOrder.ShowBeverages();
                int orderSelection = int.Parse(Console.ReadLine());
                
                    var selectedBeverages = MenuOrder.Beverages[orderSelection - 1];
                    Console.WriteLine("Enter the quantity:");
                    int quantityBeverage = int.Parse(Console.ReadLine());
                    BeverageOrders.Add(new Beverage(selectedBeverages.Name, selectedBeverages.Value, quantityBeverage));

                Console.WriteLine("Do you want to add other Beverage? Y/N");

                if (Console.ReadLine().ToLower() == "n")
                    menuContinue = false;
            } while (menuContinue);

            Console.WriteLine("The total price for  is: {0}", TotalPriceBeverage());
            Console.WriteLine("The total price for  your order is:{0}", Orderprice());

        }
        public double Orderprice()
        {
            return TotalPriceBeverage() + TotalPriceDishes();

        }

        public double TotalPriceDishes()
        {
            double total = 0;
            for (int i = 0; i < DishesOrder.Count; i++)
            {
                total += DishesOrder[i].Quantity * DishesOrder[i].PriceDish;

            }
            return total;

        }
        public double TotalPriceBeverage()
        {
            double total = 0;
            for (int i = 0; i < BeverageOrders.Count; i++)
            {
                total += BeverageOrders[i].Quantity * BeverageOrders[i].Value;

            }
            return total;

        }

        public string GetDeliverOrderInformation()
        {
            string information = string.Format("The order made by {0},the price total is:{1}",NameCustomer, Orderprice());
            return information;
        }

    }
}
