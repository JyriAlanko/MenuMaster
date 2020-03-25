using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Handler
    {
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        public List<DishMenu> DishMenus { get; set; } = new List<DishMenu>();
                
        public List<FoodClass> FoodClasses { get; set; } = new List<FoodClass>();
                
        public List<StarterDish> StarterDishes { get; set; } = new List<StarterDish>();


        public Restaurant CreateRestaurant()
        {
            Console.WriteLine("Enter Restaurant Name: ");
            var RestaurantName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            var Address = Console.ReadLine();

            Console.WriteLine("Select Food menu: ");
            

            Restaurant toReturn = new Restaurant(RestaurantName, Address);
            return toReturn;
        }

        public FoodClass CreateFoodClass()
        {
            Console.WriteLine("Enter name of the dish ");
            var FoodName = Console.ReadLine();

            Console.WriteLine("Enter contents of the dish");
            var FoodContent = Console.ReadLine();

            Console.WriteLine("Enter special info about the dish");
            var SpecialInfo = Console.ReadLine();

            Console.WriteLine("Enter price of the dish");
            var Price = Convert.ToDouble(Console.ReadLine());
            FoodClass toReturn = new FoodClass(FoodName, FoodContent, SpecialInfo, Price);
            return toReturn;
        }

        public DishMenu CreateDishMenu()
        {
            Console.WriteLine("Enter Name of the Menu");
            var MenuName = Console.ReadLine();

            Console.WriteLine("Do you wanna add dish to the menu? (Y/N");
            string MenuDecision = Console.ReadLine();

            if(MenuDecision == "Y" || MenuDecision == "y")
            {

                ////List<FoodClass> FoodClasses = new List<FoodClass>();
                //Console.WriteLine("Choose dish to add to menu:");
                //int DishNumber = 1;
                //for (int i = 0; i < FoodClasses.Count; i++)
                //{
                //    Console.WriteLine($"\n{DishNumber}. {FoodClasses[i].FoodName} \nContents: {FoodClasses[i].FoodContent} \nSpecial info: {FoodClasses[i].SpecialInfo} \nPrice: {FoodClasses[i].Price}\n\n");
                //    DishNumber++;
                //    Console.ReadKey();

                //}
                    DishMenu toReturn = new DishMenu(MenuName);
                    return toReturn;

  
            }

            else 
            { 
            
            DishMenu toReturn = new DishMenu(MenuName);
            return toReturn;

            }
        }
    } 
}
