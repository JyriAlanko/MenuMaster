using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Restaurant
    {
        //public string RestaurantName = "Penan potut";
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string FoodMenu { get; set; }

        public Restaurant(string RestaurantName, string Address)
        {
            this.RestaurantName = RestaurantName;
            this.Address = Address;
            this.FoodMenu = FoodMenu;
        }
    }
}
