namespace Decorator
{
    public abstract class Beverage
    {
        public string Description { get; set; }

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}