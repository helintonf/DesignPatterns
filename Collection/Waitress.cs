using InteratorCollection;
using System;
using System.Collections;

namespace Collection
{
    internal class Waitress
    {
        public ArrayList Menus { get; set; }
        //public IMenu PancakeHouseMenu { get; set; }
        //public IEnumerable DinerMenu { get; set; }
        //public IMenu CafeMenu { get; set; }

        //public Waitress(IMenu Menus, IEnumerable dinerMenu, IMenu cafeMenu)
        public Waitress(IMenu pancakeHouseMenu, IEnumerable dinerMenu, IMenu cafeMenu)
        {
            Menus = new ArrayList();
            Menus.Add(pancakeHouseMenu);
            Menus.Add(dinerMenu);
            Menus.Add(cafeMenu);
            //Menus = pancakeHouseMenu;
            //DinerMenu = dinerMenu;
            //CafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            ////ITerator pancIterator = PancakeHouseMenu.CreateIterator();
            //IEnumerator pancIterator = PancakeHouseMenu.CreateIterator();
            ////ITerator dinerIterator = DinerMenu.CreateIterator();
            //IEnumerator dinerIterator = DinerMenu.GetEnumerator();

            //IEnumerator cafeIterator = CafeMenu.CreateIterator();

            //Console.WriteLine("MENU\n----\nBREAKFAST");
            //PrintMenu(pancIterator);

            //Console.WriteLine("\nLUNCH");
            //PrintMenu(dinerIterator);

            //Console.WriteLine("\nDINNER");
            //PrintMenu(cafeIterator);

            IEnumerator menuIterator = Menus.GetEnumerator();

            while (menuIterator.MoveNext() && menuIterator.Current != null)
            {
                IMenu menu = (IMenu)menuIterator.Current;
                PrintMenu(menu.CreateIterator());
                //;
            }
        }

        private void PrintMenu(IEnumerator iterator)
        //private void PrintMenu(ITerator iterator)
        {
            //while (iterator.HasNext())
            while (iterator.MoveNext() && iterator.Current != null)
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                Console.WriteLine("Name: " + menuItem.Name);
                Console.WriteLine("Description: " + menuItem.Description);
                Console.WriteLine("Price: " + menuItem.Price);
            }
        }
    }
}