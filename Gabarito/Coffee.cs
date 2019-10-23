using System;

namespace Gabarito
{
    public class Coffee : CaffeineBeverage
    {
        protected override bool WantsCondiments()
        {
            Console.WriteLine("Do you want condiments? Y or N");
            var result = Console.ReadLine();

            switch (result.ToUpper())
            {
                case "Y":
                    return true;

                case "YES":
                    return true;

                case "S":
                    return true;

                case "SIM":
                    return true;

                default:
                    return false;
            }
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}