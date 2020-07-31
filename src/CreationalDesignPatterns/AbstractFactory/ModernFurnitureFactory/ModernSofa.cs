using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ModernFurnitureFactory
{
    internal class ModernSofa : ISofa
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public ModernSofa()
        {
            Design = "modern";
            Construction = "steel";
        }
    }
}