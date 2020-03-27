using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Handler
    {

        //List<Restaurant> restaurants = new List<Restaurant>();
 

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

        public DishMenu CreateDishMenu()
        {
            Console.WriteLine("Enter Name of the Menu");
            var MenuName = Console.ReadLine();

            DishMenu toReturn = new DishMenu(MenuName);
            return toReturn;
        }

        //public Restaurant AddMenuToRestaurant()
        //{

        //    chosen = 0;
        //    int MenuNamechoice = Convert.ToInt32(Console.ReadLine());
        //    MenuNamechoice = MenuNamechoice - 1;
        //    chosen.MenuName = 

        //    Restaurant chosen = new Restaurant(MenuName);



        //    var MenuName = 
        //    chosen.MenuName = new Restaurant(MenuName);

            
             


        //    Restaurant toReturn = new Restaurant(MenuName);
        //    return toReturn;
        //}

        public StarterDish CreateStarterDish()
        {

            Console.WriteLine("Enter name of the dish ");
            var StarterDishName = Console.ReadLine();

            Console.WriteLine("Enter contents of the dish");
            var StarterDishDescription = Console.ReadLine();

            Console.WriteLine("Enter special info about the dish");
            var SpecialInfo = Console.ReadLine();

            Console.WriteLine("Enter price of the dish");
            var Price = Convert.ToDouble(Console.ReadLine());

            StarterDish toReturn = new StarterDish(StarterDishName, StarterDishDescription, SpecialInfo, Price);
            return toReturn;

        }

        public Dessert CreateDessert()
        {

            Console.WriteLine("Enter name of the dish ");
            var DessertName = Console.ReadLine();

            Console.WriteLine("Enter contents of the dish");
            var DessertDescription = Console.ReadLine();

            Console.WriteLine("Enter special info about the dish");
            var SpecialInfo = Console.ReadLine();

            Console.WriteLine("Enter price of the dish");
            var Price = Convert.ToDouble(Console.ReadLine());

            Dessert toReturn = new Dessert(DessertName, DessertDescription, SpecialInfo, Price);
            return toReturn;

        }

        public MainDish CreateMainDish()
        {

            Console.WriteLine("Enter name of the dish ");
            var MainDishName = Console.ReadLine();

            Console.WriteLine("Enter contents of the dish");
            var MainDishDescription = Console.ReadLine();

            Console.WriteLine("Enter special info about the dish");
            var SpecialInfo = Console.ReadLine();

            Console.WriteLine("Enter price of the dish");
            var Price = Convert.ToDouble(Console.ReadLine());

            MainDish toReturn = new MainDish(MainDishName, MainDishDescription, SpecialInfo, Price);
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


    } 
}
