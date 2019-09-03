using System;

namespace Estrategia
{
    public class KnifeBehavior : WeaponBehavior
    {
        private readonly int Damage;
        private readonly int Area;

        public KnifeBehavior()
        {
            Damage = 8;
            Area = 1;
        }

        public void UseWeapon()
        {
            Console.WriteLine($@"Dagame is {Damage}");
        }
    }
}