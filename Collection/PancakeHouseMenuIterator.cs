using Collection;
using System.Collections;

namespace InteratorCollection
{
    internal class PancakeHouseMenuIterator : ITerator
    {
        public ArrayList Items { get; set; }
        private int position = 0;

        public PancakeHouseMenuIterator(ArrayList items)
        {
            Items = items;
        }

        public bool HasNext()
        {
            if (position >= Items.Count || Items[position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            MenuItem menuItem = (MenuItem)Items[position];
            position += 1;
            return menuItem;
        }
    }
}