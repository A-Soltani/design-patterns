using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.VictorianFurnitureFactory
{
    internal class VictorianChair : IChair
    {
        public string Design { get; set; }
        public string Construction { get; set; }

        public VictorianChair()
        {
            Design = "classic";
            Construction = "wooden";
        }
    }
}