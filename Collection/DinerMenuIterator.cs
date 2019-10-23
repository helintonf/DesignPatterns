using Collection;
using System.Collections;

namespace InteratorCollection
{
    internal class DinerMenuIterator : IEnumerator, ITerator
    {
        public MenuItem[] Items { get; set; }

        public object Current => Items[position];

        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            Items = items;
        }

        public bool HasNext()
        {
            if (position >= Items.Length || Items[position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            MenuItem menuItem = Items[position];
            position += 1;
            return menuItem;
        }

        public bool MoveNext()
        {
            position += 1;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}