using System;

namespace Estrategia
{
    public class AxeBehavior : WeaponBehavior
    {
        private readonly int Damage;
        private readonly int Area;

        public AxeBehavior()
        {
            Damage = 20;
            Area = 3;
        }

        public void UseWeapon()
        {
            Console.WriteLine($@"Dagame is {Damage}");
        }
    }
}