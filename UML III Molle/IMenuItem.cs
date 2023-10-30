using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_III_Molle
{
    public interface IMenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public MenuType Type { get; set; }
        public bool IsVegan { get; set; }
        public bool IsOrganic { get; set; }
        public string PrintInfo();
    }
}
