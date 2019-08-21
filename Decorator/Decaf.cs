using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Descafeinado";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
