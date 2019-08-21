namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Coffe";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}