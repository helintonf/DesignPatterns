namespace Decorator
{
    public class Whip : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .10 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }
    }
}