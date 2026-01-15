using System;

namespace OnlineMarketPlace
{
    public abstract class BaseProduct //abstract class
    {
        public string Name { get; set; }
        public double Price { get; set; }

        protected BaseProduct(string name, double price) // constructor
        {
            Name = name;
            Price = price;
        }
    }
}
