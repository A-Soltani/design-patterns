using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ModernFurnitureFactory
{
    internal class ModernCoffeeTable : ICoffeeTable
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public ModernCoffeeTable()
        {
            Design = "modern";
            Construction = "steel";
        }
    }
}