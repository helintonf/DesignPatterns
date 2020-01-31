using System.Collections.Generic;

namespace Composto
{
    /// <summary>
    /// Gerenciar os patos, familias e coleções, subcoleções indidivualmente
    /// </summary>
    internal class Flock : IQuackable
    {
        public List<IQuackable> Quackers { get; set; }

        public Flock()
        {
            Quackers = new List<IQuackable>();
        }

        public void Quack()
        {
            var iterator = Quackers.GetEnumerator();

            while (iterator.MoveNext() && iterator.Current != null)
            {
                iterator.Current.Quack();
            }
        }
    }
}