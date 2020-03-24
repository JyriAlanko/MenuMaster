using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class FoodMenu
    {
        //Set Restaurant somewhere

        public string FoodMenuName { get; set; }

        public List<List<StarterFood>> StarterFoods { get; set; } = new List<List<StarterFood>>();

        public List<List<MainFood>> MainFoods { get; set; } = new List<List<MainFood>>();

        public List<List<Dessert>> Desserts { get; set; } = new List<List<Dessert>>();



    }
}
