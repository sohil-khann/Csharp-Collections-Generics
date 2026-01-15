using System;
using System.Collections.Generic;
/*2. Dynamic Online Marketplace
 Concepts: Type Parameters, Generic Methods, Constraints
 Problem Statement: Build a generic product catalog for an online
marketplace supporting various product types.
 Hints:
 Define a generic class Product<T> where T is restricted to a
category (BookCategory, ClothingCategory).
 Implement a generic method void ApplyDiscount<T>(T
product, double percentage) where T : Product.
 Ensure type safety while allowing multiple product
categories in the catalog.
*/
namespace OnlineMarketPlace
{
    
    public static class OnlineMarketPlaceMain
    {
        public static void Run()
        {

            // Create products with different categories
            var book = new Product<BookCategory>("C# in Depth", 50.0, new BookCategory("Programming", "Xyz"));
            var shirt = new Product<ClothingCategory>("T-Shirt", 20.0, new ClothingCategory("Xyz", "L"));

            // Display initial details
            Console.WriteLine($"Product: {book.Name}, Price: {book.Price}, Category: {book.Category.Genre} by {book.Category.Author}");
            Console.WriteLine($"Product: {shirt.Name}, Price: {shirt.Price}, Category: {shirt.Category.Type}, Size: {shirt.Category.Size}");

            // Apply discounts using generic method
            ApplyDiscount(book, 10);
            ApplyDiscount(shirt, 20);

            Console.WriteLine("\nAfter Discounts:");
            Console.WriteLine($"Product: {book.Name}, New Price: {book.Price}");
            Console.WriteLine($"Product: {shirt.Name}, New Price: {shirt.Price}");
            Console.WriteLine();
        }

        // Generic method to apply discount to any Product
        public static void ApplyDiscount<T>(T product, double percentage) where T : BaseProduct
        {
            if (product != null)
            {
                double discountAmount = product.Price * (percentage / 100);
                product.Price -= discountAmount;
                Console.WriteLine($"Applied {percentage}% discount to {product.Name}.");
            }
        }
    }
}
