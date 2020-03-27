using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class MainDish
    {
        public string MainDishName { get; set; }

        public string MainDishDescription { get; set; }

        public string SpecialInfo { get; set; }

        public double Price { get; set; }

        public MainDish()
        {

        }
        public MainDish(string MainDishName, string MainDishDescription, string SpecialInfo, double Price)
        {
            this.MainDishName = MainDishName;
            this.MainDishDescription = MainDishDescription;
            this.SpecialInfo = SpecialInfo;
            this.Price = Price;
        }
    }
}
