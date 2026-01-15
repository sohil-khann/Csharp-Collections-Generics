using System;
namespace SmartWareHouse
{
    // Abstract class representing a warehouse item
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected WarehouseItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
    }
}