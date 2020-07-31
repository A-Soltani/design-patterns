using AbstractFactory.FurnitureFactory;

namespace AbstractFactory.ModernFurnitureFactory
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();
        public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
        public ISofa CreateSofa() => new ModernSofa();
    }
}