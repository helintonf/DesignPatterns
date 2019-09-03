using System;

namespace Estrategia
{
    public class BowAndArrowBehavior : WeaponBehavior
    {
        private readonly int Damage;
        private readonly int Area;

        public BowAndArrowBehavior()
        {
            Damage = 10;
            Area = 20;
        }

        public void UseWeapon()
        {
            Console.WriteLine($@"Dagame is {Damage}");
        }
    }
}