using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class DishMenu
    {
        //Set Restaurant somewhere

        public string MenuName { get; set; }

        public List<StarterDish> StarterDishes { get; set; } = new List<StarterDish>();
        
        public List<MainDish> MainDishes { get; set; } = new List<MainDish>();

        public List<Dessert> Desserts { get; set; } = new List<Dessert>();

        public DishMenu (string MenuName)
        {
            this.MenuName = MenuName;
        }

    }
}
