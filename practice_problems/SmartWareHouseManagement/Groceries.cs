using System;
namespace SmartWareHouse
{
    public class Groceries : WarehouseItem
    {
        private DateTime ExpirationDate { get; set; }

        public Groceries(string name, decimal price, DateTime expirationDate)
            : base(name, price)
        {
            ExpirationDate = expirationDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Grocery Item: Name: {base.Name}, Price: {base.Price:C}, Expiration Date: {ExpirationDate:MM/dd/yyyy}");
        }
    }
}