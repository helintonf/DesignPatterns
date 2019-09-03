namespace Estrategia
{
    public class King : Character
    {
        public King(WeaponBehavior weaponBehavior)
        {
            weapon = weaponBehavior;
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}