using System;

namespace Factory
{
    internal class PepperoniPizza : Pizza
    {
        private PizzaIngredientFactory pizzaIngredient;

        public PepperoniPizza(PizzaIngredientFactory pizzaIngredient)
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