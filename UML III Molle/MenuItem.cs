using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_III_Molle
{
    public class MenuItem : IMenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            Number = number;
            Name = name;
            Description = description;
            Price = price;
            Type = type;
            IsVegan = isVegan;
            IsOrganic = isOrganic;
        }

        public virtual string PrintInfo()
        {
            return "Info print";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
