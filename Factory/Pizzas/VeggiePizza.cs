using System;

namespace Factory
{
    internal class VeggiePizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredient;

        public VeggiePizza(PizzaIngredientFactory pizzaIngredient)
        {
            this.pizzaIngredient = pizzaIngredient;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing..." + Name);
            Dough = pizzaIngredient.CreateDough();
            Sauce = pizzaIngredient.CreateSauce();
            Cheese = pizzaIngredient.CreateCheese();
        }
    }
}