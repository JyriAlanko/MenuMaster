using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Handler
    {
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        public List<FoodMenu> FoodMenus { get; set; } = new List<FoodMenu>();

        public List<FoodClass> FoodClasses { get; set; } = new List<FoodClass>();


        public Restaurant CreateRestaurant()
        {
            Console.WriteLine("Enter Restaurant Name: ");
            var RestaurantName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            var Address = Console.ReadLine();

            Console.WriteLine("Enter Food menu name: ");
            var FoodMenu = Console.ReadLine();

            Restaurant toReturn = new Restaurant(RestaurantName, Address);
            return toReturn;
        }

    }
}
