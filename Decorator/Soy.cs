namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .15 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }
    }
}