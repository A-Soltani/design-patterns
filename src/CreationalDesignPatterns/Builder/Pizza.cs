using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /* "Product" */
    internal class Pizza
    {
        public string Topping { get; private set; }
        public string Sauce { get; private set; }
        public string Dough { get; private set; }
        public void SetTopping(string topping) => Topping = topping;
        public void SetSauce(string sauce) => Sauce = sauce;
        public void SetDough(string dough) => Dough = dough;
    }
}
