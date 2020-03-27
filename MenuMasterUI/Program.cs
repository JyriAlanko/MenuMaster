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
            List<StarterDish> starterDishes = new List<StarterDish>();
            List<MainDish> mainDishes = new List<MainDish>();
            List<Dessert> desserts = new List<Dessert>();

        Start:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string textToEnter = "Welcome!";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            Console.WriteLine("\nPlease Choose Action\n");
            Console.WriteLine("1.Add Restaurant \n2.Add Dish \n3.Add Menu \n4.Show Restaurants \n5.Show Dishes \n6.Show Menus \n7.Exit");


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
                    Console.WriteLine("Restaurant Added! Do you wanna add another restaurant? (Y/N)");
                    
                    var RestaurantMenu = Console.ReadLine();
                    if (RestaurantMenu == "Y" || RestaurantMenu == "y")
                    {
                        goto case 1;
                    }
                    else
                    {

                    goto Start;
                    }

                //Add Dish
                case 2:
                    Console.Clear();
                    Console.WriteLine("Adding Dish");

                    Console.WriteLine("Enter food type");
                    Console.WriteLine("\n\n1.Starter \n2.Add Main \n3.Add Dessert \n4.No Type \n5.Return to main menu");

                    int FoodType = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    if (FoodType == 1)
                    {
                        var StarterDish = dh.CreateStarterDish();
                        starterDishes.Add(StarterDish);
                        Console.Clear();

                        Console.WriteLine("Starter Dish added!");
                        Console.ReadKey();
                    }
                    if (FoodType == 2)
                    {
                        var MainDish = dh.CreateMainDish();
                        mainDishes.Add(MainDish);
                        Console.Clear();

                        Console.WriteLine("Main Dish added!");
                        Console.ReadKey();
                    }

                    if (FoodType == 3)

                    {
                        var Dessert = dh.CreateDessert();
                        desserts.Add(Dessert);
                        Console.Clear();

                        Console.WriteLine("Dessert added!");
                        Console.ReadKey();
                    }

                    if (FoodType == 4)
                    {
                        var FoodClass = dh.CreateFoodClass();
                        FoodClasses.Add(FoodClass);
                        Console.Clear();

                        Console.WriteLine("Uncatergorized food added!");
                        Console.ReadKey();
                    }

                    if(FoodType == 5)
                    {
                        Console.WriteLine("Returning to main menu, Press any key to continue");

                        goto Start;
                    }

                    if(FoodType >= 6 || FoodType <= 0)
                    {
                        Console.WriteLine("Error! Press any key to return");
                        Console.ReadKey();
                        goto case 2;
                    }

                    Console.WriteLine("Do you wanna add another Dish? (Y/N)");
                    var AddDishMenu = Console.ReadLine();

                    if(AddDishMenu == "Y" || AddDishMenu == "y")
                    {
                        goto case 2;
                    }

                    goto Start;


                //Add Food Menu
                case 3:
                    Console.Clear();
                    Console.WriteLine("Adding Food Menu");

                    var dishMenu = dh.CreateDishMenu();
                    dishMenus.Add(dishMenu);

                    ////Comment from here if not working
                    //Console.WriteLine("Do you wanna add it to restaurant? (Y/N?)");
                    //var MenuChoice = Console.ReadLine();

                    //if (MenuChoice == "Y" || MenuChoice == "y")
                    //{
                    //    Console.Clear();
                    //    int RestaurantNumber = 1;
                    //    for (int i = 0; i < restaurants.Count; i++)
                    //    {
                    //        Console.WriteLine($"\n{RestaurantNumber}.Name: {restaurants[i].RestaurantName} \n");
                    //        RestaurantNumber++;

                    //    }

                    //    int MenuNamechoice = Convert.ToInt32(Console.ReadLine());
                    //    MenuNamechoice = MenuNamechoice - 1;
                    //    Console.ReadKey();
                    //    var AddMenu = dh.AddMenuToRestaurant();
                    //    restaurants.Add(AddMenu);


                    //    goto Start;
                    //}
                    //else
                        //To here
                        Console.Clear();

                    goto Start;

                //Show Restaurants
                case 4:
                    Console.Clear();
                    Console.WriteLine("Showing Restaurants\n");
                    int RestaurantNumber2 = 1;
                    for (int i = 0; i < restaurants.Count; i++)
                    {
                        Console.WriteLine($"{RestaurantNumber2}.Name: {restaurants[i].RestaurantName} \nAddress: {restaurants[i].Address} \n");
                        RestaurantNumber2++;

                    }

                    Console.ReadKey();

                    goto Start;

                //Show FoodClass
                case 5:
                    Console.Clear();
                    Console.WriteLine("Which category foods you would like to see\n");
                    Console.WriteLine(" \n1.Starters \n2.Main \n3.Dessert \n4.Not Categorized \n5.Return to main menu");

                    var ShowFoodMenu = Convert.ToInt32(Console.ReadLine());
                    int  DishNumber = 1;
                    if(ShowFoodMenu == 1)
                    {
                        Console.Clear();
                        for (int i = 0; i < starterDishes.Count; i++)
                        {
                            Console.WriteLine($"{DishNumber}.Name: {starterDishes[i].StarterDishName} \nContent: {starterDishes[i].StarterDishDescription} \nSpecial Info: {starterDishes[i].SpecialInfo} \nPrice: {starterDishes[i].Price} \n");
                            DishNumber++;
                        }
                        Console.ReadKey();

                        goto case 5;
                    }

                    if(ShowFoodMenu == 2)
                    {
                        Console.Clear();
                        for (int i = 0; i < mainDishes.Count; i++)
                        {
                            Console.WriteLine($"{DishNumber}.Name: {mainDishes[i].MainDishName} \nContent: {mainDishes[i].MainDishDescription} \nSpecial Info: {mainDishes[i].SpecialInfo} \nPrice: {mainDishes[i].Price} \n");
                            DishNumber++;
                        }
                        Console.ReadKey();

                        goto case 5;
                    }

                    if(ShowFoodMenu == 3)
                    {
                        Console.Clear();
                        for (int i = 0; i < desserts.Count; i++)
                        {
                            Console.WriteLine($"{DishNumber}.Name: {desserts[i].DessertName} \nContent: {desserts[i].DessertDescription} \nSpecial Info: {desserts[i].SpecialInfo} \nPrice: {desserts[i].Price} \n");
                            DishNumber++;
                        }
                        Console.ReadKey();

                        goto case 5;
                    }

                    if(ShowFoodMenu == 4)
                    {
                        Console.Clear();
                        for (int i = 0; i < FoodClasses.Count; i++)
                        {
                            Console.WriteLine($"{DishNumber}.Name: {FoodClasses[i].FoodName} \nContent: {FoodClasses[i].FoodContent} \nSpecial Info: {FoodClasses[i].SpecialInfo} \nPrice: {FoodClasses[i].Price} \n");
                            DishNumber++;
                        }
                        Console.ReadKey();

                        goto case 5;
                    }

                    if(ShowFoodMenu == 5)
                    {

                        Console.WriteLine("Retuning to main menu");
                        goto Start;
                    }

                    if(ShowFoodMenu <= 0 || ShowFoodMenu >= 6)
                    {
                        Console.WriteLine("Error! Press any key to try again");

                        Console.ReadKey();

                        goto case 5;

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

                //Add Menu to Restaurant, Exit for now
                case 7:



                    break;

            }
        }
    }
}
