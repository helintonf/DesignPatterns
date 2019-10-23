using System;

namespace Gabarito
{
    public class Tea : CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            PourInCup();
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}