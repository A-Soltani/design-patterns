using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /* "Abstract Builder" */
    public abstract class PizzaBuilder
    {
        private protected Pizza Pizza;
        public Pizza GetPizza() => Pizza;
        public Pizza CreatePizza() => Pizza = new Pizza();
        public abstract void BuildTopping();
        public abstract void BuildSauce();
        public abstract void BuildDough();
    }
}
