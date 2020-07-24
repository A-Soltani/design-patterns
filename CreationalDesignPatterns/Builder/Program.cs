using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrdering pizzaOrdering = new PizzaOrdering();

            SpicyPizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            pizzaOrdering.SetPizzaBuilder(spicyPizzaBuilder);
            pizzaOrdering.ConstructPizza();
            Pizza spicyPizza = pizzaOrdering.GetPizza();
            PrintPizzaIngredients("spicy pizza", spicyPizza);

            HawaiianPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            pizzaOrdering.SetPizzaBuilder(hawaiianPizzaBuilder);
            pizzaOrdering.ConstructPizza();
            Pizza hawaiianPizza = pizzaOrdering.GetPizza();
            PrintPizzaIngredients("hawaiian pizza", hawaiianPizza);

            Console.ReadKey();
        }

        private static void PrintPizzaIngredients(string pizzaName, Pizza pizza)
        {
            Console.WriteLine($"{pizzaName} includes these ingredients: " +
                              $"{Environment.NewLine} Sauce: {pizza.Sauce} " +
                              $"{Environment.NewLine} Dough: {pizza.Dough} " +
                              $"{Environment.NewLine} Topping: {pizza.Topping} ");
        }
    }
}
