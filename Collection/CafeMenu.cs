using Collection;
using System.Collections;

namespace InteratorCollection
{
    internal class CafeMenu : IMenu
    {
        public Hashtable MenuItems { private get; set; }

        public CafeMenu()
        {
            MenuItems = new Hashtable();

            addItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato and fries",
                true, 3.99);

            addItem("Soup of the day", "A cup of soup of the day, with a side salad",
                false, 3.69);

            addItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }

        private void addItem(string v1, string v2, bool v3, double v4)
        {
            MenuItem menuItem = new MenuItem(v1, v2, v3, v4);
            MenuItems.Add(menuItem.Name, menuItem);
        }

        public IEnumerator CreateIterator()
        {
            return MenuItems.Values.GetEnumerator();
        }
    }
}