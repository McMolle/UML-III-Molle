using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_III_Molle
{
    public class MenuCatalog : IMenuCatalog
    {
        public Dictionary<int, IMenuItem> Catalog;
        public int Count => Catalog.Count;

        public MenuCatalog()
        {
            Catalog = new Dictionary<int, IMenuItem>();
        }

        public void Add(IMenuItem aMenuItem)
        {
            if (Catalog[aMenuItem.Number] ==  null)
            {
                Catalog.Add(aMenuItem.Number, aMenuItem);
            }
            else
            {
                throw new Exception($"Can't add {aMenuItem.Name} to MenuCatalog, its number already exists in the dictionary.");
            }
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            throw new NotImplementedException();
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            throw new NotImplementedException();
        }

        public void PrintBeveragesMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintPizzasMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintToppingsMenu()
        {
            throw new NotImplementedException();
        }

        public IMenuItem Search(int number)
        {
            throw new NotImplementedException();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            throw new NotImplementedException();
        }
    }
}
