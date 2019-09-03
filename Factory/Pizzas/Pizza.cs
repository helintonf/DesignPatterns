using System;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clam Clam { get; set; }

        public abstract void Prepare();

        //internal void Prepare()
        //{
        //    Console.WriteLine($"Preparing {Name}");
        //    Console.WriteLine($"Tossing dough...");
        //    Console.WriteLine($"Adding toppings:");
        //    //foreach ()
        //}

        internal void Bake()
        {
            Console.WriteLine($"Bake for 25 minutes at 350");
        }

        internal virtual void Cut()
        {
            Console.WriteLine($"Cutting the pizza into diagonar slices");
        }

        internal void Box()
        {
            Console.WriteLine($"Place pizza in official PizzaStore box");
        }
    }
}