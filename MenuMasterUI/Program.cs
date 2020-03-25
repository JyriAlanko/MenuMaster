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
            List<DishMenu> dishMenus = new List<DishMenu>();
            List<FoodClass> FoodClasses = new List<FoodClass>();

            Start:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string textToEnter = "Welcome!";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            Console.WriteLine("\nPlease Choose Action\n");
            Console.WriteLine("1.Add Restaurant \n2.Add Dish \n3.Add FoodMenu \n4.Show Restaurants \n5.Show Dishes \n6.Show FoodMenus \n7.Exit");


            var Menu = Convert.ToInt32(Console.ReadLine());

            switch (Menu)
            {
                //Add Restaurant
                case 1:

                    Console.Clear();
                    Console.WriteLine("Adding Restaurant");

                    var Restaurant = dh.CreateRestaurant();
                    restaurants.Add(Restaurant);

                    Console.Clear();
                    Console.WriteLine("Restaurant Added! Press any button to return to main menu");

                    Console.ReadKey();
                    goto Start;

                    //list.RemoveAt(2); poistaa kakkos lisän
                    //list.RemoveAll((dish => dish.name == "kolmas"); poistaa vaan dishit jossa on kolmas
                    //list.RemoveAll((dish) => dish.Equals(dish)); poistaa kaikki dish jutut


                //Add Dish
                case 2:
                    Console.Clear();
                    Console.WriteLine("Adding Dish");

                    var FoodClass = dh.CreateFoodClass();
                    FoodClasses.Add(FoodClass);

                    Console.Clear();
                    Console.WriteLine("Dish Added! Do you wanna add it to menu (Y/N)");
                    string MenuDecision = Console.ReadLine();

                    if (MenuDecision == "Y" || MenuDecision == "y")
                    {

                        //List<FoodClass> FoodClasses = new List<FoodClass>();
                        Console.WriteLine("Choose dish to add to menu:");
                        int DishNumber1 = 1;
                        for (int i = 0; i < FoodClasses.Count; i++)
                        {
                            Console.WriteLine($"\n{DishNumber1}. {FoodClasses[i].FoodName} \nContents: {FoodClasses[i].FoodContent} \nSpecial info: {FoodClasses[i].SpecialInfo} \nPrice: {FoodClasses[i].Price}\n\n");
                            DishNumber1++;
                            int AddDishToMenu = Convert.ToInt32(Console.ReadKey());

                            if(AddDishToMenu == 0)
                            {
                                goto Start;
                            }

                        }
                    }

                    goto Start;


                //Add Food Menu
                case 3:
                    Console.Clear();
                    Console.WriteLine("Adding Food Menu");

                    var DishMenu = dh.CreateDishMenu();
                    dishMenus.Add(DishMenu);


                    Console.Clear();

                    goto Start;

                //Show Restaurants
                case 4:
                    Console.Clear();
                    Console.WriteLine("Showing Restaurants\n");
                    int RestaurantNumber = 1;
                    for (int i = 0; i < restaurants.Count; i++)
                    {
                        Console.WriteLine($"\n{RestaurantNumber}.Name: {restaurants[i].RestaurantName} \nAddress: {restaurants[i].Address}");
                        RestaurantNumber++;

                    }
                    Console.ReadKey();

                    goto Start;

                //Show FoodClass
                case 5:
                    Console.Clear();
                    Console.WriteLine("Showing Foods");
                    int DishNumber = 1;
                    for (int i = 0; i < FoodClasses.Count; i++)
                    {
                        Console.WriteLine($"\n{DishNumber}.Name: {FoodClasses[i].FoodName} \nContents: {FoodClasses[i].FoodContent} \nSpecial info: {FoodClasses[i].SpecialInfo} \nPrice: {FoodClasses[i].Price}\n\n");


                    }
                    Console.ReadKey();

                    goto Start;

                //Show FoodMenu
                case 6:
                    Console.Clear();
                    Console.WriteLine("Showing Menus\n\n");
                    int MenuNumber = 1;
                    for (int i = 0; i < dishMenus.Count; i++)
                    {
                        Console.WriteLine($"{MenuNumber}. {dishMenus[i].MenuName}\n");
                        MenuNumber++;

                    }
                    Console.ReadKey();
                    goto Start;

                case 7:
                    break;

            }
        }
    }
}
