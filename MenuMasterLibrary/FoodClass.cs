using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class FoodClass
    {
        public string FoodName { get; set; }


        public string FoodContent { get; set; }


        public string SpecialInfo { get; set; }


        public double Price { get; set; }


        public FoodClass(string FoodName, string FoodContent, string SpecialInfo, double Price)
        {
            this.FoodName = FoodName;
            this.FoodContent = FoodContent;
            this.SpecialInfo = SpecialInfo;
            this.Price = Price;
        }

    }
            
}

