using System;

namespace Factory
{
    internal class ClamPizza : Pizza
    {
        PizzaIngredientFactory pizzaIngredient;

        public ClamPizza(PizzaIngredientFactory pizzaIngredient)
        {
            this.pizzaIngredient = pizzaIngredient;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing..." + Name);
            Dough = pizzaIngredient.CreateDough();
            Sauce = pizzaIngredient.CreateSauce();
            Cheese = pizzaIngredient.CreateCheese();
            Clam = pizzaIngredient.CreateClam();
        }
    }
}