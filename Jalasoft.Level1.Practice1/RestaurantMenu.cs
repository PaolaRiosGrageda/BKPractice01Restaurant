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

        private int exitOption;
        public RestaurantMenu() {
            MenuRestaurant= new Menu(); 
            exitOption = 0;
        }
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
            Console.WriteLine("2. Show Menu");
            Console.WriteLine("3. Register order ");
            Console.WriteLine("4. Show debt");
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
                    MenuRestaurant.Show();
                    break;
                case 2:
                    Console.WriteLine("usted seleciono 2");
                    break;
                case 3: Console.WriteLine("Usted selecciono 3");
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
