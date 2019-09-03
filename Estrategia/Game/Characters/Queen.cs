namespace Estrategia
{
    public class Queen : Character
    {
        public Queen(WeaponBehavior weaponBehavior)
        {
            weapon = weaponBehavior;
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}