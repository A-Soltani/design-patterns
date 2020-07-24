using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /* "ConcreteBuilder" */
    internal class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildTopping() => Pizza.SetTopping("ham+pineapple");
        public override void BuildSauce() => Pizza.SetSauce("mild");
        public override void BuildDough() => Pizza.SetDough("cross");
    }
}
