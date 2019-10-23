using System;
using System.Collections;

namespace InteratorCollection.Composto
{
    internal class Waitress
    {
        public MenuComponent Menus { get; set; }

        public Waitress(MenuComponent menus)
        {
            Menus = menus;
        }

        public void PrintMenu()
        {
            Menus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = Menus.CreateIterator();
            Console.WriteLine("Vegetarian Menu");

            while (enumerator.MoveNext() && enumerator.Current != null)
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;

                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException e)
                {
                }
            }
        }
    }
}