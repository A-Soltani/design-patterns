using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class SpicyPizzaBuilder: PizzaBuilder
    {
        public override void BuildTopping() => Pizza.SetTopping("pepperoni+salami");
        public override void BuildSauce() => Pizza.SetSauce("hot");
        public override void BuildDough() => Pizza.SetDough("pan baked");
    }
}
