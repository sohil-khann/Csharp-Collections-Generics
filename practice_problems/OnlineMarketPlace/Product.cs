using System;

namespace OnlineMarketPlace
{
    public class Product<T> : BaseProduct where T : class //product generic class
    {
        public T Category { get; set; } //generic type getter,setter

        public Product(string name, double price, T category) : base(name, price)
        {
            Category = category;
        }
    }
}
