namespace Estrategia
{
    public abstract class Character
    {
        public WeaponBehavior weapon { get; set; }

        public abstract void Fight();
    }
}