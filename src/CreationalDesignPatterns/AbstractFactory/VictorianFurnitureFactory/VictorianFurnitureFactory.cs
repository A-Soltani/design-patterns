using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.VictorianFurnitureFactory
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair();
        public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
        public ISofa CreateSofa() => new VictorianSofa();
    }
}