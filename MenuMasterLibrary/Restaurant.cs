using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Restaurant
    {
        
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string MenuName { get; set; }

        public Restaurant()
        {

        }

        public Restaurant(string MenuName)
        {
            this.MenuName = MenuName;

        }

        public Restaurant(string RestaurantName, string Address)
        {
            this.RestaurantName = RestaurantName;
            this.Address = Address;
            
        }
    }
}
