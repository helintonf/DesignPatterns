namespace Factory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            factory = pizzaFactory;
        }

        public Pizza Order(string type)
        {
            Pizza pizza;

            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}