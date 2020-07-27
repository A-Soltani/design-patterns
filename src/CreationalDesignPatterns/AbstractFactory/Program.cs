using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFurnitureFactory modernfurnitureFactory = new ModernFurnitureFactory();
            IFurnitureFactory victorianfurnitureFactory = new VictorianFurnitureFactory();
        }
    }

    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new VictorianChair() { Material = "wood", Weight = 10 };

        public ICoffeeTable CreateCoffeeTable()
        {
            throw new NotImplementedException();
        }

        public ISofa CreateSofa()
        {
            throw new NotImplementedException();
        }
    }

    internal class VictorianChair : IChair
    {
        public string Material { get; set; }
        public int Weight { get; set; }
    }

    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            throw new NotImplementedException();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            throw new NotImplementedException();
        }

        public ISofa CreateSofa()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ISofa CreateSofa();
    }

    internal interface ISofa
    {

    }

    internal interface ICoffeeTable
    {

    }

    internal interface IChair
    {
        string Material { get; set; }
        int Weight { get; set; }
    }
}
