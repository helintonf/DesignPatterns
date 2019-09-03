namespace Factory
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();

        Sauce CreateSauce();

        Cheese CreateCheese();

        Veggies[] CreateViggies();

        Pepperoni CreatePepperoni();

        Clam CreateClam();
    }
}