using System.Collections;
using System.Collections.Generic;

namespace InteratorCollection.Composto
{
    internal class CompositeIterator : IEnumerator
    {
        private Stack<IEnumerator> enumerators;

        public CompositeIterator(IEnumerator enumerator)
        {
            enumerators = new Stack<IEnumerator>();

            this.enumerators.Push(enumerator);
        }

        object IEnumerator.Current => GetCurrent();

        public object GetCurrent()
        {
            IEnumerator enumerator = enumerators.Peek();
            if (enumerator.Current != null)
            {
                MenuComponent component = (MenuComponent)enumerator.Current;
                if (component is Menu)
                {
                    enumerators.Push(component.CreateIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }

        public bool MoveNext()
        {
            if (enumerators.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = enumerators.Peek();

                if (!enumerator.MoveNext())
                {
                    enumerators.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}