using InteratorCollection;
using System.Collections;

namespace Collection
{
    internal class PancakeHouseMenu : IEnumerable, IMenu
    {
        public ArrayList MenuItems { get; set; }

        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with scrambled fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancake", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Pancakes with choice of blueberries or strawberries", true, 3.59);
        }

        private void AddItem(string v1, string v2, bool v3, double v4)
        {
            MenuItem menuItem = new MenuItem(v1, v2, v3, v4);

            MenuItems.Add(menuItem);
        }

        //public ITerator CreateIterator()
        public IEnumerator CreateIterator()
        {
            return MenuItems.GetEnumerator();
            // return new PancakeHouseMenuIterator(MenuItems);
        }

        public IEnumerator GetEnumerator()
        {
            return MenuItems.GetEnumerator();
        }
    }
}