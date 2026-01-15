using System;
namespace SmartWareHouse 
{
    public class Electronics : WarehouseItem
    {
        private string Brand { get; set; }
        private string Model { get; set; }

        public Electronics(string name, decimal price, string brand, string model)
            : base(name, price)
        {
            Brand = brand;
            Model = model;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronics Item: {Brand} {Model}, Name: {base.Name}, Price: {base.Price:C}");
        }

    }
}