using InteratorComposto.Composto;
using System;
using System.Collections;

namespace InteratorCollection.Composto
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegeratarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool vegeratarian, double price)
        {
            Name = name;
            Description = description;
            Vegeratarian = vegeratarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsVegetarian()
        {
            return Vegeratarian;
        }

        public override void Print()
        {
            Console.WriteLine(Name);
            if (Vegeratarian)
            {
                Console.WriteLine(" (v) ");
            }
            Console.WriteLine(Price);
            Console.WriteLine(Description);
        }

        public override IEnumerator CreateIterator()
        {
            return new NullIterator();
        }
    }
}