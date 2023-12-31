﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_III_Molle
{
    public class Beverage : MenuItem
    {
        public bool ContainsAlcohol { get; set; }

        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool containsAlcohol) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
            ContainsAlcohol = containsAlcohol;
        }

        public override string PrintInfo()
        {
            return "Beverage print info";
        }

    }
}
