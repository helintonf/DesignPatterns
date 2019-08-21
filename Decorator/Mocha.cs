namespace Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + Beverage.Cost();
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}