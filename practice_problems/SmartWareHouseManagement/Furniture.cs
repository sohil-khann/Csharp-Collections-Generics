using System;
namespace SmartWareHouse
{
    public class Furniture : WarehouseItem 
    {
        private string Material { get; set; }
        private string Dimensions { get; set; }

        public Furniture(string name, decimal price, string material, string dimensions)
            : base(name, price)
        {
            Material = material;
            Dimensions = dimensions;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Furniture Item: Name: {base.Name}, Price: {base.Price:C}, Material: {Material}, Dimensions: {Dimensions}");
        }
    }
}