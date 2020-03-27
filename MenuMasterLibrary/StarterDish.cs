using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class StarterDish
    {
        public string StarterDishName { get; set; }

        public string StarterDishDescription { get; set; }

        public string SpecialInfo { get; set; }

        public double Price { get; set; }

        public StarterDish()
        {

        }
        public StarterDish(string StarterDishName, string StarterDishDescription, string SpecialInfo, double Price)
        {
            this.StarterDishName = StarterDishName;
            this.StarterDishDescription = StarterDishDescription;
            this.SpecialInfo = SpecialInfo;
            this.Price = Price;
        }
    }
}
