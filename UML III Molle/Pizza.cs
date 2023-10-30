using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_III_Molle
{
    public class Pizza : MenuItem
    {
        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan) : base(number, name, description, price, type, isVegan, isOrganic)
        {

        }

        public bool DeepPan { get; set; }

    }
}
