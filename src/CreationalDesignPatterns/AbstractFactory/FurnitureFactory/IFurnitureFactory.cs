namespace AbstractFactory.FurnitureFactory
{
    internal interface IFurnitureFactory
    {
        IChair CreateChair();
        ICoffeeTable CreateCoffeeTable();
        ISofa CreateSofa();
    }
}