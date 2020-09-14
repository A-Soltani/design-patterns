using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            IShoppingApplications shoppingApplications = new MobileApplications();
            Console.WriteLine("Hello World!");
        }
    }

    internal class MobileApplications : IShoppingApplications
    {
        public void AddItem(string itemCode)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IShoppingApplications
    {
        void AddItem(string itemCode);
    }
}
