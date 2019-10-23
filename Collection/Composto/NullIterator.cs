using System;
using System.Collections;

namespace InteratorComposto.Composto
{
    internal class NullIterator : IEnumerator
    {
        public object Current => null;

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}