using System;
using AbstractFactory.FurnitureFactory;
using AbstractFactory.VictorianFurnitureFactory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectedCollection = "victorian";
            IFurnitureFactory victorianFurnitureFactory = GetFurnitureFactory(selectedCollection);
            PrintSelectedCollectionDetails(victorianFurnitureFactory, selectedCollection);

            selectedCollection = "modern";
            IFurnitureFactory modernFurnitureFactory = GetFurnitureFactory(selectedCollection);
            PrintSelectedCollectionDetails(modernFurnitureFactory, selectedCollection);

            Console.ReadKey();
        }

        private static void PrintSelectedCollectionDetails(IFurnitureFactory furnitureFactory, string selectedCollection)
        {
            var chair = furnitureFactory.CreateChair();
            var coffeeTable = furnitureFactory.CreateCoffeeTable();
            var sofa = furnitureFactory.CreateSofa();

            Console.WriteLine($"***** collection name: {selectedCollection} *****");
            Console.WriteLine($"Chair{Environment.NewLine}" +
                              $"Design: {chair.Design} {Environment.NewLine}" +
                              $"Construction: {chair.Construction} {Environment.NewLine}");

            Console.WriteLine($"Coffee Table{Environment.NewLine}" +
                              $"Design: {coffeeTable.Design} {Environment.NewLine}" +
                              $"Construction: {coffeeTable.Construction} {Environment.NewLine}");

            Console.WriteLine($"Sofa{Environment.NewLine}" +
                              $"Design: {sofa.Design} {Environment.NewLine}" +
                              $"Construction: {sofa.Construction} {Environment.NewLine}");
        }

        private static IFurnitureFactory GetFurnitureFactory(string selectedCollection)
        {
            if (selectedCollection == "victorian")
                return new VictorianFurnitureFactory.VictorianFurnitureFactory();
            else
                return new ModernFurnitureFactory.ModernFurnitureFactory();
        }
    }
}
