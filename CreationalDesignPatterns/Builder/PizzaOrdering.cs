using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class PizzaOrdering
    {
        private PizzaBuilder _pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pizzaBuilder) => _pizzaBuilder = pizzaBuilder;
        public Pizza GetPizza() => _pizzaBuilder.GetPizza();
        public void ConstructPizza()
        {
            _pizzaBuilder.CreatePizza();
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}
