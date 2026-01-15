/*1. Smart Warehouse Management System
 Concepts: Generic Classes, Constraints, Variance
 Problem Statement: Develop a warehouse system that manages
different types of items (Electronics, Groceries, Furniture).
 Hints:
 Create an abstract class WarehouseItem that all items
extend (Electronics, Groceries, Furniture).
 Implement a generic class Storage<T> where T :
WarehouseItem to store items safely.
 Implement a method to display all items using List<T>.*/
 using System;
 namespace SmartWareHouse
 {
     public static class SmartWareHouseMain
     {
         public static void Run()
         {
             // Create storage for Electronics
             Storage<Electronics> electronicsStorage = new Storage<Electronics>();
             electronicsStorage.AddItem(new Electronics("Laptop", 999.99m, "Dell", "XPS 13"));
             electronicsStorage.AddItem(new Electronics("Smartphone", 699.99m, "Apple", "iPhone 13"));

             // Create storage for Furniture
             Storage<Furniture> furnitureStorage = new Storage<Furniture>();
             furnitureStorage.AddItem(new Furniture("Sofa", 499.99m, "Leather", "80x35x30"));
             furnitureStorage.AddItem(new Furniture("Dining Table", 299.99m, "Wood", "60x40x30"));
             //Create Grceries Storage
             Storage<Groceries> groceriesStorage = new Storage<Groceries>();
                groceriesStorage.AddItem(new Groceries("Apples", 2.99m, DateTime.Now.AddDays(10)));
                groceriesStorage.AddItem(new Groceries("Milk", 1.49m, DateTime.Now.AddDays(5)));

             // Display all Electronics items
             Console.WriteLine("Electronics in Storage:");
             electronicsStorage.DisplayAllItems();

             // Display all Furniture items
             Console.WriteLine("\nFurniture in Storage:");
             furnitureStorage.DisplayAllItems();
            // Display all Groceries items
            Console.WriteLine("\nGroceries in Storage:");
            groceriesStorage.DisplayAllItems();
         }
     }
 }