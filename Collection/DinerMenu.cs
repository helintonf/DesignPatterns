using InteratorCollection;
using System;
using System.Collections;

namespace Collection
{
    internal class DinerMenu : IEnumerable, IMenu
    {
        private readonly int MAX_ITENS = 6;

        public int NumberOfItens { get; set; }
        public MenuItem[] MenuItems { get; set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITENS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hordog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }

        private void AddItem(string v1, string v2, bool v3, double v4)
        {
            MenuItem menuItem = new MenuItem(v1, v2, v3, v4);

            if (NumberOfItens >= MAX_ITENS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[NumberOfItens] = menuItem;
                NumberOfItens += 1;
            }
        }

        public IEnumerator CreateIterator()
        //public ITerator CreateIterator()
        {
            return new DinerMenuIterator(MenuItems);
        }

        public IEnumerator GetEnumerator()
        {
            return MenuItems.GetEnumerator();
        }
    }
}