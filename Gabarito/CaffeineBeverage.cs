using System;

namespace Gabarito
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (WantsCondiments())
            {
                AddCondiments();
            }
        }

        protected virtual bool WantsCondiments()
        {
            return true;
        }

        protected void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        protected abstract void Brew();

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected abstract void AddCondiments();
    }
}