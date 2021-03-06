﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Dessert
    {
        public string DessertName { get; set; }

        public string DessertDescription { get; set; }

        public string SpecialInfo { get; set; }

        public double Price { get; set; }

        public Dessert()
        {

        }
        public Dessert(string DessertName, string DessertDescription, string SpecialInfo, double Price)
        {
            this.DessertName = DessertName;
            this.DessertDescription = DessertDescription;
            this.SpecialInfo = SpecialInfo;
            this.Price = Price;
        }
    }
}
