using System;

namespace Collection
{
    internal class Duck : IComparable
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public int CompareTo(object obj)
        {
            Duck otherDocuk = (Duck)obj;

            if (this.Weight < otherDocuk.Weight)
            {
                return -1;
            }
            else if (this.Weight == otherDocuk.Weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $@"Name: {Name} - Weight: {Weight}";
        }
    }
}