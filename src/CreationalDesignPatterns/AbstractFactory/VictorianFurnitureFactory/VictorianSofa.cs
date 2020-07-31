using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.VictorianFurnitureFactory
{
    internal class VictorianSofa : ISofa
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public VictorianSofa()
        {
            Design = "classic";
            Construction = "wooden";
        }
    }
}