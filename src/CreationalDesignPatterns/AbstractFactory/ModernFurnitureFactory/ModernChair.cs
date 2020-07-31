using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ModernFurnitureFactory
{
    internal class ModernChair : IChair
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public ModernChair()
        {
            Design = "modern";
            Construction = "steel";
        }
    }
}