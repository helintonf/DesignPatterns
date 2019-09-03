namespace Estrategia
{
    public class Troll : Character
    {
        public Troll(WeaponBehavior weaponBehavior)
        {
            weapon = weaponBehavior;
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}