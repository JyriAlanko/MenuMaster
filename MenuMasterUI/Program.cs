using System;
using System.Collections.Generic;

using MenuMasterLibrary;

namespace MenuMasterUI
{
    class Program
    {

        static void Main(string[] args)
        {
            var dh = new Handler();

            List<Restaurant> restaurants = new List<Restaurant>();
            List<FoodMenu> foodMenus = new List<FoodMenu>();

            Start:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string textToEnter = "Welcome!";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            Console.WriteLine("\nPlease Choose Action\n");
            Console.WriteLine("1.Add Restaurant \n2.Add FoodMenu \n3.Add FoodClass \n4.Show Restaurants \n5.Show FoodMenus \n6.Show FoodClasses");


            var Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                //Add Restaurant
                case 1:

                    Console.Clear();
                    Console.WriteLine("Adding Restaurant");

                    var Restaurant = dh.CreateRestaurant();
                    restaurants.Add(Restaurant);



                    //Restaurant restaurants = new Restaurant();
                    //restaurants.Add(new Restaurant() { RestaurantName = "Penan Potku", Address = "Penantie 13" }); 
                    //Restaurant restaurants = new Restaurant();
                    //restaurants.RestaurantName = "Penan potku";
                    //restaurants.Address = "Penantie 13";


                    Console.Clear();
                    Console.WriteLine("Restaurant Added! Press anybutton to return to main menu");



                    Console.ReadKey();
                    goto Start;

                    //list.RemoveAt(2); poistaa kakkos lisän
                    //list.RemoveAll((dish => dish.name == "kolmas"); poistaa vaan dishit jossa on kolmas
                    //list.RemoveAll((dish) => dish.Equals(dish)); poistaa kaikki dish jutut

                //Add FoodMenu
                case 2:
                    Console.Clear();
                    Console.WriteLine("Adding FoodMenu");

                    break;

                //Add FoodClass
                case 3:
                    Console.Clear();
                    Console.WriteLine("Adding Food");

                    break;

                //Show Restaurants
                case 4:
                    Console.Clear();
                    Console.WriteLine("Showing Restaurants\n");

                    for (int i = 0; i < restaurants.Count; i++)
                    {
                        Console.WriteLine($"\nName: {restaurants[i].RestaurantName} \nAddress: {restaurants[i].Address}");
 

                    }
                    Console.ReadKey();

                    goto Start;

                //Show FoodMenu
                case 5:
                    Console.Clear();
                    Console.WriteLine("Showing Food Menus");

                    break;

                //Show FoodClass
                case 6:
                    Console.Clear();
                    Console.WriteLine("Showing Foods");

                    break;

            }
        }
    }
}
