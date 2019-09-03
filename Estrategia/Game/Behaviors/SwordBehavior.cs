using System;

namespace Estrategia
{
    public class SwordBehavior : WeaponBehavior
    {
        private readonly int Damage;
        private readonly int Area;

        public SwordBehavior()
        {
            Damage = 15;
            Area = 2;
        }

        public void UseWeapon()
        {
            Console.WriteLine($@"Dagame is {Damage}");
        }
    }
}