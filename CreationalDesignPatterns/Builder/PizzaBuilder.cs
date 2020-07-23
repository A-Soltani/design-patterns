using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        private protected Pizza Pizza;
        public Pizza GetPizza() => Pizza;
        public Pizza CreatePizza() => new Pizza();
        public abstract void BuildTopping();
        public abstract void BuildSauce();
        public abstract void BuildDough();
    }
}
