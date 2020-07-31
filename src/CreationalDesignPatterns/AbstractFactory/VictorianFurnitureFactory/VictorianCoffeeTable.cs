using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.VictorianFurnitureFactory
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public VictorianCoffeeTable()
        {
            Design = "classic";
            Construction = "wooden";
        }
    }
}